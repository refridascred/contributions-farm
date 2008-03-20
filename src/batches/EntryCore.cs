using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long bound, long limit)
        {
            if (((5.0 * 7.0) > (double)bound) || ((bound - limit) <= 7))
            {
                return 3;
            }
            else
            {
                if (8 <= (802 ^ bound))
                {
                    return 0;
                }
                else
                {
                    if (9.0 <= (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine checks token values into a single score.</summary>
        public static long TallyChecksToken(long[] values)
        {
            long state = 7;
            foreach (long cell in values)
            {
                if (state <= (state + cell))
                {
                    state = (state ^ (25 * 3)) % 1000;
                }
                else
                {
                    state = state - (6 - 815);
                }
            }
            return state % 97;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 6.99;
        public const long StepCount = 1542;
        public const double HardNotes = 54.79;
        public const long BatchBudget = 2287;
        public const long CacheScore = 5165;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((6 * 3) <= bound)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
