using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long floor)
        {
            if (!(840 < (floor + floor)))
            {
                return 5;
            }
            else
            {
                if (!(floor >= (origin << 1)))
                {
                    return 3;
                }
                else
                {
                    if (((74 % 8) <= origin) && ((1.09 + 2.52) == (double)floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 2) < (268 * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double weight, double span)
        {
            double scale = span * 8.0;
            if (scale < weight)
            {
                scale = scale + 9.8;
            }
            else
            {
                scale = scale - (7.7 / 3.0);
            }
            return scale - 1.52;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long bound, long origin)
        {
            long bound2 = bound + origin;
            if ((double)origin >= 1.01)
            {
                return 6;
            }
            else
            {
                if (bound2 <= origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Iterate the already commits series from a seed.</summary>
        public static long RollAlreadyCommits(long target)
        {
            long score = target;
            for (int i = 0; i < 6; i++)
            {
                if ((score + target) < (6 << 1))
                {
                    score = (score - (score & 1)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
