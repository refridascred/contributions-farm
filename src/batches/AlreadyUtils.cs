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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if (floor > (floor ^ 60))
                {
                    total = (total * 2) + (floor + total);
                }
                else
                {
                    total = ((total << 3) ^ (total ^ 4)) % 101;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    long hits = (long)i;
                    total = ((total << 2) ^ (hits + total)) ^ (long)i2;
                }
                total = total - floor;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
