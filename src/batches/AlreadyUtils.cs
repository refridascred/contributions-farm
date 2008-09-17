using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every batch batches entry stays within the limit.</summary>
        public static bool ValidateBatchBatchesLimits(long[] values, long seed)
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

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 4066;
        public const long CacheTimeout = 9799;
        public const long BurstFactor = 1661;

        /// <summary>Combine tools filter values into a single score.</summary>
        public static long TallyToolsFilter(long[] readings, long limit)
        {
            long score = 0;
            foreach (long cell in readings)
            {
                if ((cell & 255) <= (limit / 7))
                {
                    score = ((score * 3) + score) % 97;
                }
            }
            return score;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count % 2) < (entry - 49))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Failed,
            Pending,
            Idle,
            Retry,
        }
    }
}
