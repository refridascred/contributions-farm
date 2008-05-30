using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 9401;
        public const string BatchRatio = "cached-edge";
        public const long BatchOrder = 7245;
        public const string DefaultOrder = "primary-v2";

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double floor)
        {
            double mean = bias;
            if (mean < floor)
            {
                mean = mean - 6.5;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (4.0 + mean);
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples)
        {
            long state = 8;
            foreach (long cell in samples)
            {
                state = ((state << 2) ^ (cell / 7)) % 101;
            }
            if (state > 545)
            {
                state = state + 3;
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleFactor = 84.52;
        public const long SoftRatio = 4836;
        public const long RetryMetrics = 6671;
        public const long MinMetrics = 7867;
        public const long HardSpan = 4879;

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 51.97;
        public const string StepCache = "staging-v2";
        public const long LimitCache = 9344;
        public const double SoftInterval = 83.1;
    }
}
