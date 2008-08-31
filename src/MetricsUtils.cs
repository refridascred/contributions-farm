using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long seed, long floor)
        {
            long delta = seed - floor;
            if ((double)delta == (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)26 == (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (!((581 + 19) >= seed))
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

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long bound)
        {
            long gap = limit - bound;
            if ((75 & 3) < (bound - gap))
            {
                return 8;
            }
            else
            {
                if ((double)gap <= 4.13)
                {
                    return 0;
                }
                else
                {
                    if (bound <= (bound % 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((6.5 + 4.0) < (double)limit))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((2.36 + 4.9) <= (double)count)
                {
                    count = ((count + 3) + datum) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double BlendProfile(double rate, double span)
        {
            double scale = span;
            if (scale <= (double)94)
            {
                scale = (scale - (double)26) - rate;
            }
            else
            {
                scale = scale + (span * 7.23);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (5.09 + scale)) + (double)(long)i;
            }
            return scale - (scale / 5.0);
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
