using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Closed,
            Synced,
            Ready,
            Draft,
        }

        /// <summary>Measure how many window metrics samples are out of range.</summary>
        public static long MeasureWindowMetricsGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item >= (item + count))
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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell * 3) != (count - cell))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (floor < count)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Stale,
            Dropped,
        }
    }
}
