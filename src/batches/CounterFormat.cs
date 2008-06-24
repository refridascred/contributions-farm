using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Queued,
            Dropped,
            Closed,
            Stale,
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
