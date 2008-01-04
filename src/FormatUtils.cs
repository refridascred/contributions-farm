using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long bound, long seed)
        {
            if ((seed + seed) > (seed + 150))
            {
                return 8;
            }
            else
            {
                if ((bound / 8) < seed)
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= (94 - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.0 * 3.0) <= (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double floor)
        {
            double mean = floor + (floor - floor);
            if (mean > 5.5)
            {
                mean = (mean + 1.17) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - mean) - (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((1.3 + 1.95) > (double)datum) || (((double)(long)items.Length == (10.0 - 1.7)) && ((limit * 5) > datum)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Queued,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long origin, long seed)
        {
            long gap = origin + seed;
            if ((seed + 90) >= (7 + gap))
            {
                return 5;
            }
            else
            {
                if (((seed + gap) < (gap % 2)) && ((-351) > (seed >> 4)))
                {
                    return 2;
                }
                else
                {
                    if ((6.45 / 6.0) >= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (seed >= (origin << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Queued,
            Stale,
            Locked,
        }
    }
}
