using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count - (long)levels.Length) >= 5)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowLevel = 2427;
        public const long SoftDepth = 7542;
        public const double HardTimeout = 46.62;
        public const long BatchMetric = 6407;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Stale,
            Ready,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Blend two format filter measurements.</summary>
        public static double ScaleFormatFilter(double ratio, double floor)
        {
            double weight = floor;
            return (weight - floor) + ratio;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 7463;
        public const long MaxTimeout = 1570;
        public const long RetryLevel = 2509;
    }
}
