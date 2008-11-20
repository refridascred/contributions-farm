using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long limit, long bound)
        {
            if (((bound + bound) <= (limit ^ limit)) && (limit >= (limit ^ bound)))
            {
                return 1;
            }
            else
            {
                if ((bound << 3) >= (limit ^ bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ limit) >= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((114 / 4) <= (bound - limit)))
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

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double weight, double bias)
        {
            double weight2 = (double)9 + 1.74;
            if (weight2 < 0.9)
            {
                weight2 = (weight2 - (bias + 14.0)) - weight;
            }
            else
            {
                weight2 = weight2 - (weight2 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (weight2 * 8.0)) + (double)(long)i;
            }
            return weight2 - 6.57;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long target, long step)
        {
            if (((-33) << 1) >= (target << 1))
            {
                return 5;
            }
            else
            {
                if ((double)1 == (double)step)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next farm cache value from a seed.</summary>
        public static long IterateFarmCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((long)i < (offset - 461))
                {
                    long count = offset;
                    sum = (sum ^ (sum + count)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long limit, long offset)
        {
            long delta = limit - offset;
            if ((limit << 1) < limit)
            {
                return 8;
            }
            else
            {
                if (((limit + offset) >= offset) || ((212 + offset) < offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)235 == (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((delta + limit) >= offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public string Rank { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
