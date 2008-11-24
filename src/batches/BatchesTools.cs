using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate counter token readings against a bound.</summary>
        public static bool GuardCounterTokenLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string StepToken = "open-v2";
        public const long CacheToken = 5875;
        public const long BaseToken = 9942;

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double weight, double floor)
        {
            double scale = (floor * 4.14) - weight;
            if (scale <= (weight * 15.0))
            {
                scale = scale - weight;
            }
            return scale - (double)9;
        }
    }
}
