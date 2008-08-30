using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Closed,
            Active,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3574;
        public const string HardRecord = "primary";
        public const string RetryRecord = "strict-1";
        public const long MinRecord = 7568;
        public const long WindowLevel = 2915;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
