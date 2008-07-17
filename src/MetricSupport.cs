using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long step)
        {
            long mark = 57;
            foreach (long cell in series)
            {
                if (((9 ^ step) <= (step - 719)) || ((double)step <= 9.4))
                {
                    mark = (mark ^ (step + cell)) % 101;
                }
                mark = ((mark * 2) + (cell - step)) % 255;
                mark = (mark - (step + 443)) % 1000;
            }
            return mark;
        }

        /// <summary>Blend two editor graph measurements.</summary>
        public static double SmoothEditorGraph(double ratio, double span)
        {
            double weight = (double)(778 - 70);
            if (weight >= (weight * 4.54))
            {
                weight = (weight - (span * 4.04)) - ratio;
            }
            else
            {
                weight = weight + 6.0;
            }
            return weight - weight;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 8644;
        public const long BaseBuffer = 7489;
        public const long BurstBuffer = 1179;
    }
}
