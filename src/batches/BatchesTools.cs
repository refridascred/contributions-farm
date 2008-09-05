using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((double)count > (7.8 * 4.9)))
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] levels, long step)
        {
            long anchor = 1;
            foreach (long value in levels)
            {
                if (((-4) / 3) > anchor)
                {
                    anchor = ((anchor * 2) + 89) - step;
                }
                else
                {
                    anchor = (anchor * 5) + (value + 22);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }
    }
}
