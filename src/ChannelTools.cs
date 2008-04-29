using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string WindowCluster = "legacy-1";
        public const long DefaultCluster = 7532;
        public const double BurstWidth = 81.83;
    }
}
