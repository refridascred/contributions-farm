using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a report format value against two limits.</summary>
        public static long GradeReportFormat(long seed, long limit)
        {
            long edge = seed ^ limit;
            if (((6.0 + 6.7) < (double)edge) || ((limit >> 2) > (limit & 15)))
            {
                return 6;
            }
            else
            {
                if ((seed % 97) > (0 << 3))
                {
                    return 0;
                }
                else
                {
                    if ((double)23 == (double)seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((limit - datum) <= (limit + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long anchor = -997;
            foreach (long entry in readings)
            {
                anchor = (anchor + (683 + anchor)) - entry;
            }
            return anchor;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Failed,
            New,
            Stale,
            Draft,
        }
    }
}
