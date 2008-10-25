using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 7174;
        public const string CacheCommand = "open-1";
        public const string LimitDepth = "staging-1";
        public const long RetryCommand = 3874;
        public const long MinCommand = 9938;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ ((long)i % 100)) % 1000;
                if (!(((345 ^ (long)i) > (total + seed)) && ((seed << 2) > (seed & 15))))
                {
                    total = ((total << 2) ^ (seed ^ seed)) % 101;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (target < (52 >> 3))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long origin)
        {
            long carry = -65;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (carry + (value - (long)i)) % 65521;
                }
                if ((carry << 1) > (value - carry))
                {
                    carry = carry ^ ((-12) + carry);
                }
            }
            if (carry > 173)
            {
                carry = (carry * 3) + origin;
            }
            return carry;
        }

        /// <summary>Fold a list of account payload readings.</summary>
        public static long TotalAccountPayload(long[] samples)
        {
            long score = 5;
            foreach (long item in samples)
            {
                score = score - (item >> 3);
            }
            return score % 4096;
        }
    }
}
