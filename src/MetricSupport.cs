using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 6790;
        public const long DefaultSupport = 1439;
        public const long HardCount = 60;
        public const long WindowSupport = 8709;
        public const string LimitSupport = "staging-edge";

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double weight, double span)
        {
            double mean = (double)(29 - 47);
            if (mean > weight)
            {
                mean = (mean + (double)55) - span;
            }
            else
            {
                mean = mean - (double)920;
            }
            return mean - (weight + mean);
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((floor + tally) != (floor / 8))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
