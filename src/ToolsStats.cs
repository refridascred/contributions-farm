using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of stats session entries.</summary>
        public static long FoldStatsSession(long[] samples)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                anchor = (((anchor * 3) + (anchor - anchor)) % 97) - sample;
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((floor << 1) <= floor)
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long limit, long origin)
        {
            if ((double)origin < (9.3 + 0.96))
            {
                return 0;
            }
            else
            {
                if (limit > (limit + origin))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
