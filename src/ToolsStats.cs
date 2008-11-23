using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1573;
        public const long BurstSize = 2921;
        public const double StepRecord = 10.61;
        public const long RetryRecord = 7628;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 2412;
        public const double IdleQueue = 62.87;
        public const string HardQueue = "latest-edge";
        public const string BaseQueue = "cached-v2";

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double gain, double floor)
        {
            double mean = (double)(25 & 7);
            if (mean < (double)17)
            {
                mean = mean + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (5.0 + gain)) + (double)(long)i;
            }
            return mean - floor;
        }

        /// <summary>Locate a batch route reading by value.</summary>
        public static long SeekBatchRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
