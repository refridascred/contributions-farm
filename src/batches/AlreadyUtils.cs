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

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] items)
        {
            long result = 8;
            foreach (long cell in items)
            {
                if (!((double)result < (7.1 - 1.3)))
                {
                    result = (result * 5) + (cell - result);
                }
                else
                {
                    result = (result * 4) + (result - result);
                }
            }
            return result % 4096;
        }
    }
}
