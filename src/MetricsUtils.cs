using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Closed,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double scale, double span)
        {
            double weight = (double)476;
            if (weight >= (7.88 * 8.75))
            {
                weight = (weight + (scale + weight)) - span;
            }
            return weight + (double)84;
        }

        /// <summary>Grade a metrics commits value against two limits.</summary>
        public static long BucketMetricsCommits(long seed, long bound)
        {
            if (((seed / 7) < bound) && ((double)bound < (double)seed))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= (3.0 * 0.4))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
