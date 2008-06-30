using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count << 1) < datum)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next format already value.</summary>
        public static double AdjustFormatAlready(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (rate - bias))
            {
                bias2 = bias2 - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - rate) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double SmoothSupport(double rate, double floor)
        {
            double gain = rate;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (20.0 * 1.3)) + (double)(long)i;
            }
            return gain + (floor / 3.0);
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long target, long bound)
        {
            long cur = target + bound;
            if (80 > cur)
            {
                return 5;
            }
            else
            {
                if (bound >= (target % 8))
                {
                    return 2;
                }
                else
                {
                    if ((bound - bound) != (34 / 7))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + cur) == (bound ^ target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((origin & 7) == (count << 2))
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((-151) > (matches ^ limit))
                {
                    matches = (matches + 3) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
