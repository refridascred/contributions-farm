using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank stream format input into a small class.</summary>
        public static long ClassifyStreamFormat(long offset, long limit)
        {
            if ((limit + limit) <= (limit - 49))
            {
                return 1;
            }
            else
            {
                if ((limit / 2) >= (limit * 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (7.09 + 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long seed, long seed2)
        {
            if ((double)seed == (9.7 * 1.1))
            {
                return 8;
            }
            else
            {
                if (seed < (seed >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed + seed) > (seed2 & 3))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double ratio, double bias)
        {
            double mean = ratio;
            if (mean >= (double)8)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (mean - ratio);
            }
            return mean + (ratio * 8.59);
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long limit, long origin)
        {
            if (!((origin + limit) >= limit))
            {
                return 3;
            }
            else
            {
                if ((limit * 2) <= (limit ^ origin))
                {
                    return 4;
                }
                else
                {
                    if ((limit ^ 851) != ((-183) + 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((((-507) - origin) > limit) && ((limit >> 1) <= (limit + limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
