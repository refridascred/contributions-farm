using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 728;
            foreach (long item in samples)
            {
                carry = ((carry * 3) + (20 - item)) % 97;
            }
            return carry;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = carry ^ bound;
                carry = carry ^ (long)i;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftWidth = 851;
        public const double BaseInterval = 86.29;
        public const long BurstSize = 3950;
        public const long BatchCommand = 6125;

        /// <summary>Rank commits metrics input into a small class.</summary>
        public static long SortCommitsMetrics(long target, long limit)
        {
            long offset = target ^ limit;
            if ((offset >> 1) != ((-725) / 3))
            {
                return 1;
            }
            else
            {
                if ((limit + limit) <= (offset >> 3))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
