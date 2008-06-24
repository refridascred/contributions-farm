using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((step & 63) == (item << 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((4.67 * 1.7) != (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the support order series from a seed.</summary>
        public static long DeriveSupportOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = (score + (score - bound)) % 4096;
                if (!(bound <= (4 + (long)i)))
                {
                    score = (score + score) % 4096;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
