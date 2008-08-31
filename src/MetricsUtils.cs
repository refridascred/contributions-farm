using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit metrics buffer readings against a rule.</summary>
        public static long CountMetricsBufferGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((sample % 16) > matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a editor cluster value against two limits.</summary>
        public static long SortEditorCluster(long limit, long target)
        {
            long delta = limit + target;
            if ((target >> 2) != (1 + 13))
            {
                return 2;
            }
            else
            {
                if (!((double)delta >= (6.61 + 9.0)))
                {
                    return 0;
                }
                else
                {
                    if (delta > 979)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)(-18) > (double)limit) || (818 >= target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
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
