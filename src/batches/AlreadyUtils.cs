using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Active,
            Retry,
        }

        /// <summary>Count the channel command entries that pass the check.</summary>
        public static long AuditChannelCommandMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits < (6.3 + 0.5))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if (offset > ((-7) - offset))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) > (offset2 - 392))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepWidth = 7078;
        public const long WindowBatches = 6195;
        public const long DefaultBatches = 5529;
        public const long BurstBatches = 4556;

        /// <summary>Measure how many cache counter samples are out of range.</summary>
        public static long MeasureCacheCounterOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((13.0 / 9.0) <= (double)count)
                {
                    count = ((count + 2) + item) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
