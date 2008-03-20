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

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Pending,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
