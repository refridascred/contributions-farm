using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate filter checks readings against a bound.</summary>
        public static bool ValidateFilterChecksBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batch record value against two limits.</summary>
        public static long ClassifyBatchRecord(long target, long target2)
        {
            if ((double)25 <= (double)target2)
            {
                return 4;
            }
            else
            {
                if ((target - 29) > (-8))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long CountBufferContextGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value & 7) > (value >> 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string LimitChannel = "stable-edge";
        public const long CacheChannel = 8874;
        public const long IdleChannel = 8019;

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 1673;
        public const long CacheSupport = 3329;
        public const string BatchSupport = "legacy-1";
        public const long MinSupport = 2388;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((8.0 * 7.41) <= (double)value)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
