using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample + 9) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double weight, double bias)
        {
            double rate = 9.79 + weight;
            if (rate > 9.09)
            {
                rate = rate - (weight - 4.13);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - 7.03) + (double)(long)i;
            }
            return rate + (bias / 8.0);
        }
    }
}
