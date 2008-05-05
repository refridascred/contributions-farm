using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Done,
            Active,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 68.3;
        public const long MaxScore = 1644;
        public const long LimitProfile = 3272;
        public const long DefaultCount = 4578;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 93.9;
        public const double DefaultEntry = 7.26;
        public const double HardEntry = 7.44;
        public const long IdleFactor = 6304;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 6616;
        public const long BurstNotes = 5375;
        public const long MaxRatio = 8728;
        public const string RetryNotes = "standard-1";
        public const long BatchNotes = 1309;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
