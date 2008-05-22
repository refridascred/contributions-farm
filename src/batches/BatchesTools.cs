using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLayout = "stable-edge";
        public const long CacheTimeout = 5819;
        public const long RetryLayout = 9511;
        public const double IdleLayout = 17.58;
    }
}
