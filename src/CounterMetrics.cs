using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine account contributi values into a single score.</summary>
        public static long ScoreAccountContributi(long[] samples, long floor)
        {
            long acc = 6;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (acc + (long)i) % 97;
                }
                if (((double)acc <= (9.5 + 11.0)) || ((acc + entry) >= (floor * 2)))
                {
                    acc = ((acc * 3) + (floor ^ acc)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (!((885 + sum) == ((long)i << 2)))
                {
                    sum = (sum * 2) + (-16);
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] series, long target)
        {
            long score = 49;
            foreach (long datum in series)
            {
                if (((8.82 * 4.54) >= (double)target) || ((5 % 8) > score))
                {
                    score = (score - (datum + datum)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            New,
            Done,
            Active,
        }
    }
}
