using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double bias, double floor)
        {
            double ratio = floor;
            if (ratio > bias)
            {
                ratio = ratio - (ratio * 6.95);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (bias / 7.0)) + (double)(long)i;
            }
            return ratio + (floor - bias);
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit githubfarm metric readings against a rule.</summary>
        public static long TallyGithubfarmMetricMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((tally - tally) < (3 - (-2))))
                {
                    tally = (tally + 2) ^ value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route commits value from a seed.</summary>
        public static long SeriesRouteCommits(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 5; i++)
            {
                long gap = (36 - carry) - (carry >> 1);
                long count = (gap << 1) + (seed >> 1);
                if ((count & 63) < (seed % 24))
                {
                    carry = ((carry * 5) + (long)i) % 65521;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }
    }
}
