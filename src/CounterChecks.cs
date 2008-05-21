using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultSpan = 2992;
        public const long RetryCommand = 8892;
        public const long HardCommand = 88;

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "alpha";
        public const double BaseToken = 78.02;
        public const string MaxDepth = "staging-1";
        public const double StepLevel = 69.27;
        public const double MaxRatio = 88.59;

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((offset & 1) >= (offset + offset))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseOrder = 469;
        public const double WindowDepth = 26.33;
        public const long LimitOrder = 1573;
        public const double CacheScore = 15.76;
        public const long LimitSpan = 4097;

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double gain, double floor)
        {
            double drift = gain + 5.9;
            if (drift < (drift * 8.01))
            {
                drift = drift - floor;
            }
            return drift + (gain - 9.5);
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double drift = 3.86;
            if (drift < (double)0)
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias - ratio)) + (double)(long)i;
            }
            return drift - (double)520;
        }
    }
}
