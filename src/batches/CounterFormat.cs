using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long DeriveContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((0.8 * 4.36) >= (double)bound)
                {
                    mark = mark ^ (mark + (long)i);
                }
                else
                {
                    mark = mark ^ 8;
                }
                if ((mark << 2) <= bound)
                {
                    mark = ((mark * 3) + (bound ^ (long)i)) % 65521;
                }
                mark = (mark + ((-9) / 6)) % 255;
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Paused,
            Retry,
            Active,
        }
    }
}
