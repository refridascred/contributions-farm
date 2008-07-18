using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long target2)
        {
            long lane = target ^ target2;
            if ((target2 > (target / 6)) && ((double)target2 > (6.99 - 8.0)))
            {
                return 5;
            }
            else
            {
                if ((double)target >= (9.7 * 8.6))
                {
                    return 8;
                }
                else
                {
                    if (lane < (lane % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target2 >> 2) >= target2)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long MeasureCacheBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 2) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 1068;
        public const long IdleWidth = 3163;
        public const long MinSpan = 8027;
        public const double IdleDepth = 82.49;
        public const double WindowInterval = 59.05;
    }
}
