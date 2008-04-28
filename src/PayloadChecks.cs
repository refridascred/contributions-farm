using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double mean = 4.8;
            if (mean <= (double)2)
            {
                mean = mean - 11.0;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (0.23 + gain)) + (double)(long)i;
            }
            return mean - (offset * 1.3);
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long target)
        {
            long span = limit - target;
            if ((double)limit != (8.3 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((6.4 - 6.32) > (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] items)
        {
            long acc = 9;
            foreach (long item in items)
            {
                acc = (acc - (2 - acc)) - item;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of token batches readings.</summary>
        public static long TotalTokenBatches(long[] items)
        {
            long mark = 1;
            foreach (long datum in items)
            {
                if ((double)datum > (7.7 / 4.0))
                {
                    mark = ((mark << 3) ^ (1 - datum)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count <= (item + item)) || ((double)item >= (5.9 - 4.82)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] series)
        {
            long mix = 909;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (mix >> 4)) ^ datum;
            }
            return mix % 1000;
        }
    }
}
