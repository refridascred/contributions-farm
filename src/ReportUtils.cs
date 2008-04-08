using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (double)count))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count >> 2) <= (item - item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long offset, long bound)
        {
            if ((bound << 1) < offset)
            {
                return 5;
            }
            else
            {
                if (bound <= (offset * 2))
                {
                    return 6;
                }
                else
                {
                    if ((0.18 * 17.0) > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset < (offset << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((double)bound == (8.1 / 9.0)) || ((value - bound) <= bound))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
