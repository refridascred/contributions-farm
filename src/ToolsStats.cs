using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Queued,
            Dropped,
            Closed,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)item >= (double)59)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long offset)
        {
            long result = offset;
            for (int i = 0; i < 13; i++)
            {
                if (769 >= (offset & 255))
                {
                    result = (result * 3) + (long)i;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data, long bound)
        {
            long score = 36;
            foreach (long entry in data)
            {
                score = (((score << 2) ^ (score >> 4)) ^ entry) + bound;
            }
            return score;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits / 4) < (item % 64))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
