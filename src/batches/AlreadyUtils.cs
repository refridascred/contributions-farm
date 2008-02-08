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

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardCounter = "fallback-edge";
        public const long RetryCounter = 7683;
        public const long BurstFactor = 2127;
        public const long IdleCounter = 9538;
        public const long CacheScore = 9962;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (((7 + datum) < (datum & 15)) && (datum <= (count % 97)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two format filter measurements.</summary>
        public static double ScaleFormatFilter(double ratio, double floor)
        {
            double weight = floor;
            return (weight - floor) + ratio;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            Done,
            Pending,
        }
    }
}
