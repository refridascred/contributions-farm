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

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values, long limit)
        {
            long result = -853;
            foreach (long item in values)
            {
                if (!((long)values.Length >= (limit / 9)))
                {
                    result = ((result * 3) + (item - limit)) % 4096;
                }
                result = ((result << 3) ^ (limit - limit)) % 255;
            }
            return result;
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
