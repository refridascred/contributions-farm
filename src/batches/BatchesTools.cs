using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many cluster channel samples are out of range.</summary>
        public static long CountClusterChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen >= (origin / 4))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
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
