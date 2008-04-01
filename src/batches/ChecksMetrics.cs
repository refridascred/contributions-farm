using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long RollFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((anchor / 9) >= seed)
                {
                    anchor = ((anchor << 2) ^ (seed << 2)) % 65521;
                    anchor = (anchor - seed) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Classify a graph notes pair into a bucket.</summary>
        public static long GradeGraphNotes(long seed, long origin)
        {
            long offset = seed + origin;
            if ((12.0 / 9.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((seed % 3) < offset)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowSpan = 7724;
        public const string LimitTools = "cached-edge";
        public const long RetryDepth = 3159;
        public const string RetryTools = "local-v2";
        public const double CacheTools = 24.92;

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long origin)
        {
            if ((origin - bound) == (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if (((55 / 7) > (bound * 4)) && ((bound & 63) > origin))
                {
                    return 1;
                }
                else
                {
                    if (45 <= (bound * 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((origin * 2) >= (origin ^ origin)) || (origin >= 0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmRange(long[] data, long step)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double gain, double floor)
        {
            double bias = (floor + gain) - (double)302;
            if (bias < (double)1)
            {
                bias = bias + (floor * 11.0);
            }
            return bias + floor;
        }
    }
}
