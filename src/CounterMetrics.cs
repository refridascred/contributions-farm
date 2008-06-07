using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (71 >= (matches + origin))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double ratio, double floor)
        {
            double bias = (double)(6 << 1);
            return (bias - floor) + ratio;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long origin, long limit)
        {
            long diff = origin - limit;
            if (!((double)diff < (9.3 + 19.0)))
            {
                return 5;
            }
            else
            {
                if ((diff % 12) >= (3 >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((3 << 2) <= (origin % 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)limit != (double)origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryCount = 2314;
        public const string MinTools = "cached-edge";
        public const long MaxFactor = 9819;
    }
}
