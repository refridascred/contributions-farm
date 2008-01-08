using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long seed, long offset)
        {
            long edge = seed + offset;
            if (!(edge >= (offset << 2)))
            {
                return 8;
            }
            else
            {
                if ((double)offset != (7.0 - 2.33))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of stats order readings.</summary>
        public static long TallyStatsOrder(long[] samples)
        {
            long result = 0;
            foreach (long sample in samples)
            {
                result = (((result * 5) + (945 << 1)) % 65521) ^ sample;
            }
            return result % 97;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((8.95 * 3.0) >= (double)count)
                {
                    count = ((count + 2) ^ cell) + bound;
                }
            }
            return count;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            Pending,
            Failed,
            Draft,
        }
    }
}
