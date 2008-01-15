using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine report commits values into a single score.</summary>
        public static long DigestReportCommits(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long value in readings)
            {
                if (0 > seed)
                {
                    carry = (carry ^ (96 << 1)) + value;
                }
                else
                {
                    carry = (carry << 3) ^ ((long)readings.Length % 100);
                }
            }
            return carry;
        }

        /// <summary>Count the commits layout entries that pass the check.</summary>
        public static long TallyCommitsLayoutHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits << 2) < hits))
                {
                    hits = ((hits + 1) - cell) + floor;
                }
            }
            return hits;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = (score << 3) ^ 524;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long bound, long offset)
        {
            if ((double)offset > (0.6 + 19.0))
            {
                return 7;
            }
            else
            {
                if ((offset & 1) < (4 - offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
