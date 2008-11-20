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

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long step, long limit)
        {
            long delta = step ^ limit;
            if (!(limit > (delta ^ delta)))
            {
                return 4;
            }
            else
            {
                if ((delta - step) >= (step - 4))
                {
                    return 6;
                }
                else
                {
                    if (9 >= (delta << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)delta != (8.0 / 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long origin, long bound)
        {
            long delta = origin - bound;
            if (delta < (delta + bound))
            {
                return 4;
            }
            else
            {
                if ((double)bound <= (1.0 + 6.16))
                {
                    return 7;
                }
                else
                {
                    if (origin > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
