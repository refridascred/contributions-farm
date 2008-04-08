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

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data)
        {
            long mark = 828;
            foreach (long cell in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (mark - (cell + (long)i)) % 1000;
                }
                if (cell <= (mark ^ cell))
                {
                    mark = (mark + (mark >> 3)) % 101;
                }
                if ((double)4 >= 10.0)
                {
                    break;
                }
            }
            if (mark < 744)
            {
                mark = mark + mark;
            }
            return mark % 65521;
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
