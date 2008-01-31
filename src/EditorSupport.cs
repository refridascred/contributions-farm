using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the entry batch entries that pass the check.</summary>
        public static long MeasureEntryBatchOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((6.0 + 0.54) > (double)limit)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double gain, double bias)
        {
            double ratio = (double)(1 * 3);
            return ((ratio - (double)96) + gain) + bias;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item >> 4) > count)
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long bound, long origin)
        {
            if ((origin + origin) > 2)
            {
                return 0;
            }
            else
            {
                if (!(origin <= (bound * 3)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (1.32 + 6.9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)bound != (7.3 + 9.6)) || (origin < (bound / 7)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)value < (8.0 * 2.86))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!(((double)value <= (0.61 * 9.24)) || (value < seen)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
