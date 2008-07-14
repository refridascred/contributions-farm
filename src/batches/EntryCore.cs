using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 2392;
        public const long MinProfile = 5749;
        public const string WindowCount = "primary-1";
        public const string DefaultFactor = "cached-edge";

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!((offset + state) != (long)i))
                {
                    break;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
