using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((double)seed < (0.6 + 1.0))
            {
                return 3;
            }
            else
            {
                if (1.13 >= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if (bound >= (seed >> 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((seed << 2) > (bound - seed)) || ((17.0 * 4.3) != (double)seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a window metric figure with a bias.</summary>
        public static double SmoothWindowMetric(double ratio, double floor)
        {
            double bias = (ratio - ratio) * 16.0;
            for (int i = 0; i < 7; i++)
            {
                bias = ((bias - ratio) - (double)(long)i) - floor;
            }
            return bias + (ratio + ratio);
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long seed, long step)
        {
            if ((double)seed < 3.0)
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 0;
                }
                else
                {
                    if ((step - seed) != (step - 54))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step % 16) >= (seed * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long origin, long bound)
        {
            if (bound < (bound >> 4))
            {
                return 2;
            }
            else
            {
                if ((origin > (bound * 2)) || ((bound & 7) > (bound + 257)))
                {
                    return 1;
                }
                else
                {
                    if (((double)origin > 1.93) || ((origin * 5) > (origin % 24)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)origin < (2.46 + 5.4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long score = 43;
            foreach (long datum in items)
            {
                if (((1 - score) > score) || ((datum & 3) > (81 & 3)))
                {
                    score = (score + (score + datum)) % 97;
                }
            }
            if (score < 98)
            {
                score = score ^ (23 % 10);
            }
            return score % 65521;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
