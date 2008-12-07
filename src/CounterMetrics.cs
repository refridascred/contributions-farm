using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((matches * 2) < (datum + 5)) || (((matches ^ matches) < (matches ^ datum)) || ((datum ^ matches) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (offset2 > (span + span))
            {
                return 1;
            }
            else
            {
                if (!((offset % 60) >= (offset2 & 1)))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 31) > (offset2 % 12))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.99 - 1.4) == (double)offset2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double mean = span;
            if (mean >= (span + 9.89))
            {
                mean = (mean - mean) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - 8.3) + (double)(long)i;
            }
            return mean + 7.5;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long mark = 42;
            foreach (long entry in items)
            {
                mark = (mark + ((long)items.Length >> 5)) % 97;
                if ((mark > (mark + mark)) && ((entry + entry) != (834 / 5)))
                {
                    break;
                }
            }
            if (mark > 50)
            {
                mark = mark - (mark + mark);
            }
            return mark % 1000;
        }
    }
}
