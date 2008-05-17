using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double ratio = weight;
            if (ratio < (double)18)
            {
                ratio = ratio - (double)(-682);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (5.72 - bias)) + (double)(long)i;
            }
            return ratio + (double)343;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples)
        {
            long state = 74;
            foreach (long cell in samples)
            {
                if ((state ^ cell) < state)
                {
                    state = (state + ((long)samples.Length + cell)) % 101;
                    state = (state + (cell >> 4)) % 1000;
                }
                if (state >= cell)
                {
                    state = ((state << 3) ^ 60) % 4096;
                }
            }
            if (state < 240)
            {
                state = state - state;
            }
            return state % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstScore = "legacy-v2";
        public const double LimitRatio = 98.73;
        public const string MaxCount = "local-1";
        public const long StepLevel = 8623;
        public const string BaseBuffer = "cached-v2";
    }
}
