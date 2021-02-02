using System;
using LibCommon.Enums;

namespace LibCommon.Structs.WebRequest
{
    /// <summary>
    /// 添加音视频通道实例的请求结构
    /// id,mainid,createTime,updateTime不用传
    /// </summary>
    [Serializable]
    public class ReqAddVideoChannel
    {
        private string _mediaServerId;
        private string _app;
        private string _vhost;
        private string? _channelName;
        private string? _departmentId;
        private string? _departmentName;
        private string? _pDepartmentId;
        private string? _pDepartmentName;
        private DeviceNetworkType _deviceNetworkType;
        private DeviceStreamType _deviceStreamType;
        private MethodByGetStream _methodByGetStream;
        private VideoDeviceType _videoDeviceType;
        private bool _autoVideo;
        private bool _autoRecord;
        private int? _recordSecs;
        private string? _recordPlanName;
        private string _ipV4Address;
        private string? _ipV6Address;
        private bool _hasPtz;
        private string? _deviceId;
        private string? _channelId;
        private bool? _rtpWithTcp;
        private string? _videoSrcUrl;
        private bool? _defaultRtpPort;
        private bool? _enabled;
        private bool? _noPlayerBreak;

        public string MediaServerId
        {
            get => _mediaServerId;
            set => _mediaServerId = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string App
        {
            get => _app;
            set => _app = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Vhost
        {
            get => _vhost;
            set => _vhost = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string? ChannelName
        {
            get => _channelName;
            set => _channelName = value;
        }

        public string? DepartmentId
        {
            get => _departmentId;
            set => _departmentId = value;
        }

        public string? DepartmentName
        {
            get => _departmentName;
            set => _departmentName = value;
        }

        public string? PDepartmentId
        {
            get => _pDepartmentId;
            set => _pDepartmentId = value;
        }

        public string? PDepartmentName
        {
            get => _pDepartmentName;
            set => _pDepartmentName = value;
        }

        public DeviceNetworkType DeviceNetworkType
        {
            get => _deviceNetworkType;
            set => _deviceNetworkType = value;
        }

        public DeviceStreamType DeviceStreamType
        {
            get => _deviceStreamType;
            set => _deviceStreamType = value;
        }

        public MethodByGetStream MethodByGetStream
        {
            get => _methodByGetStream;
            set => _methodByGetStream = value;
        }

        public VideoDeviceType VideoDeviceType
        {
            get => _videoDeviceType;
            set => _videoDeviceType = value;
        }

        public bool AutoVideo
        {
            get => _autoVideo;
            set => _autoVideo = value;
        }

        public bool AutoRecord
        {
            get => _autoRecord;
            set => _autoRecord = value;
        }

        public int? RecordSecs
        {
            get => _recordSecs;
            set => _recordSecs = value;
        }

        public string? RecordPlanName
        {
            get => _recordPlanName;
            set => _recordPlanName = value;
        }

        public string IpV4Address
        {
            get => _ipV4Address;
            set => _ipV4Address = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string? IpV6Address
        {
            get => _ipV6Address;
            set => _ipV6Address = value;
        }

        public bool HasPtz
        {
            get => _hasPtz;
            set => _hasPtz = value;
        }

        public string? DeviceId
        {
            get => _deviceId;
            set => _deviceId = value;
        }

        public string? ChannelId
        {
            get => _channelId;
            set => _channelId = value;
        }

        public bool? RtpWithTcp
        {
            get => _rtpWithTcp;
            set => _rtpWithTcp = value;
        }

        public string? VideoSrcUrl
        {
            get => _videoSrcUrl;
            set => _videoSrcUrl = value;
        }

        public bool? DefaultRtpPort
        {
            get => _defaultRtpPort;
            set => _defaultRtpPort = value;
        }

        public bool? Enabled
        {
            get => _enabled;
            set => _enabled = value;
        }

        public bool? NoPlayerBreak
        {
            get => _noPlayerBreak;
            set => _noPlayerBreak = value;
        }
    }
}