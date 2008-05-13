using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string IdleStats = "staging-edge";
        public const double MaxSpan = 75.48;
        public const long SoftStats = 6698;
        public const long BurstStats = 8019;

        /// <summary>Classify a tools notes pair into a bucket.</summary>
        public static long SortToolsNotes(long seed, long origin)
        {
            if ((double)seed > (16.0 - 4.61))
            {
                return 8;
            }
            else
            {
                if ((0.3 - 8.0) > (6.23 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Score { get; set; }
        }
    }
}
