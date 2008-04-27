using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the buffer stats entries that pass the check.</summary>
        public static long AuditBufferStatsGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((floor * 2) <= floor)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cache token reading.</summary>
        public static double AdjustCacheToken(double weight, double span)
        {
            double gain = weight - 14.0;
            return (gain - weight) + span;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitDepth = 2921;
        public const string DefaultContributi = "standard-v2";
        public const long MinContributi = 9377;
        public const long MaxLevel = 6587;

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Count { get; set; }
            public string Flag { get; set; } = "";
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
