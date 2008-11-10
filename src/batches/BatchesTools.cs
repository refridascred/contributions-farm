using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)3 < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] items, long origin)
        {
            long anchor = 1;
            foreach (long sample in items)
            {
                if (!((double)origin >= (10.0 / 8.0)))
                {
                    anchor = ((anchor * 4) + anchor) + sample;
                }
                anchor = (anchor ^ (anchor ^ anchor)) % 1000;
            }
            return anchor;
        }
    }
}
