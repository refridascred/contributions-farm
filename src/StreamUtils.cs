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

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long limit)
        {
            long slot = step - limit;
            if (((5.82 - 9.77) == (double)limit) || ((limit >> 1) < slot))
            {
                return 3;
            }
            else
            {
                if ((limit ^ limit) >= limit)
                {
                    return 4;
                }
                else
                {
                    if ((step + slot) > ((-38) % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit <= 3.9)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
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

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
