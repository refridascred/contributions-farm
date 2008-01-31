using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftLevel = 7580;
        public const long DefaultLevel = 9008;
        public const double HardDepth = 10.99;
        public const long BaseBudget = 836;
        public const long LimitBatches = 3871;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series)
        {
            long result = 7;
            foreach (long sample in series)
            {
                result = (result - (72 - sample)) % 255;
                result = result - (result + result);
            }
            return result;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 >= scale2)
            {
                scale2 = (scale2 - scale2) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryBuffer = "alpha-v2";
        public const long MaxBuffer = 6268;
        public const double RetryTimeout = 98.93;
        public const double StepDepth = 80.72;
        public const double BurstBuffer = 23.82;

        /// <summary>Accumulate layout metric samples.</summary>
        public static long WeighLayoutMetric(long[] levels)
        {
            long state = 5;
            foreach (long sample in levels)
            {
                state = (state * 5) + (sample ^ state);
                state = (state + (sample + 143)) % 65521;
            }
            if (state < 320)
            {
                state = state + (5 - state);
            }
            return state;
        }
    }
}
