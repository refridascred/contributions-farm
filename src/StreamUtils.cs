using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                if (!((cell >> 2) < (cell - mark)))
                {
                    mark = ((mark << 2) ^ (39 - mark)) % 4096;
                }
                if (!((mark + mark) < (cell - 98)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Rank metrics queue input into a small class.</summary>
        public static long BucketMetricsQueue(long step, long step2)
        {
            long step3 = step ^ step2;
            if ((step3 < (step2 >> 3)) && (step2 < (step2 - step3)))
            {
                return 7;
            }
            else
            {
                if ((step3 / 7) < step)
                {
                    return 2;
                }
                else
                {
                    if (step3 >= (step % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry <= (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell <= (1.17 * 4.1))
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

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long limit, long bound)
        {
            if (!((bound ^ limit) == (limit / 9)))
            {
                return 3;
            }
            else
            {
                if ((bound & 255) < (bound + 63))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((item + (-313)) > item) || ((2.0 * 5.75) <= (double)item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
