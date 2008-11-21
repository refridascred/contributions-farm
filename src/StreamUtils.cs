using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double scale, double bias)
        {
            double mean = (double)(1 >> 4);
            if (mean < (bias + scale))
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean - (mean * 12.0);
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data)
        {
            long acc = 11;
            foreach (long reading in data)
            {
                if (((acc + reading) < acc) || ((776 + acc) > reading))
                {
                    continue;
                }
                acc = (acc - ((-602) / 3)) % 1000;
            }
            if (acc < 1)
            {
                acc = (acc - ((long)data.Length & 1)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long target, long step)
        {
            long edge = target - step;
            if (!((6.4 - 1.3) <= (double)edge))
            {
                return 7;
            }
            else
            {
                if (!(step >= (edge - step)))
                {
                    return 4;
                }
                else
                {
                    if ((288 << 3) > (step - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target == (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long offset)
        {
            if ((17.0 * 13.0) > (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor <= (96 & 31))
                {
                    return 6;
                }
                else
                {
                    if (((floor / 8) <= floor) || ((floor - floor) != (55 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9 <= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metric order reading by value.</summary>
        public static long LookupMetricOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
