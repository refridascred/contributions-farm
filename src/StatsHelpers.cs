using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long step)
        {
            long diff = limit + step;
            if ((step - diff) < limit)
            {
                return 7;
            }
            else
            {
                if ((diff % 100) >= (2 ^ limit))
                {
                    return 6;
                }
                else
                {
                    if ((-80) <= (step << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - 10) < (step << 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long floor, long bound)
        {
            long diff = floor ^ bound;
            if ((bound - 50) >= floor)
            {
                return 4;
            }
            else
            {
                if ((diff + bound) == (20 * 3))
                {
                    return 7;
                }
                else
                {
                    if (!(191 >= (bound & 255)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((double)bound >= (double)390))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftInterval = "cached-edge";
        public const double RetryBatch = 36.99;
        public const long CacheLevel = 8474;
        public const double DefaultTimeout = 77.1;
        public const long MinSize = 5086;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long floor, long bound)
        {
            if ((floor / 4) < 8)
            {
                return 6;
            }
            else
            {
                if ((440 - bound) <= (bound - floor))
                {
                    return 8;
                }
                else
                {
                    if ((2.0 / 2.0) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
