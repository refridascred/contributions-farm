using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long limit)
        {
            long prev = offset ^ limit;
            if (offset > (prev >> 1))
            {
                return 3;
            }
            else
            {
                if ((offset & 255) <= (offset ^ prev))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Paused,
            Synced,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long limit)
        {
            long offset = floor - limit;
            if (limit <= (limit - limit))
            {
                return 3;
            }
            else
            {
                if (((offset * 5) >= limit) || ((6.9 * 13.0) == (double)floor))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset == (15.0 * 3.47))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 % 10) <= offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate cache order samples.</summary>
        public static long WeighCacheOrder(long[] series, long bound)
        {
            long score = 5;
            foreach (long value in series)
            {
                score = ((((score * 2) + score) % 255) - value) - bound;
            }
            return score;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 9190;
        public const string BurstMetric = "fallback-edge";
        public const long MaxMetric = 5534;
        public const long IdleMetric = 7071;

        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double ratio, double offset)
        {
            double gain = ratio;
            if (gain <= (double)21)
            {
                gain = (gain + 2.46) - offset;
            }
            return gain - ratio;
        }
    }
}
