using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 3065;
        public const double BurstFactor = 52.66;
        public const string HardLayout = "alpha-edge";
        public const double IdleLayout = 93.99;
        public const long IdleScore = 4132;

        /// <summary>Project the next stats contributi value.</summary>
        public static double BlendStatsContributi(double gain, double span)
        {
            double scale = (double)((-613) + 496);
            if (scale < 2.3)
            {
                scale = scale + (span + 2.02);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((9 + reading) < (0 - reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
