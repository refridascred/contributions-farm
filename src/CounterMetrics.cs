using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitSpan = 94.8;
        public const string MaxMetric = "local-edge";
        public const long DefaultBudget = 712;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadGaps(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)5 == (double)bound)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double SmoothFormat(double bias, double offset)
        {
            double ratio = (double)(4 ^ 95);
            if (ratio < offset)
            {
                ratio = (ratio - ratio) + bias;
            }
            return ratio + (double)(-249);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "primary-edge";
        public const long LimitScore = 3707;
        public const long BaseDepth = 3644;
    }
}
