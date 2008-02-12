using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((limit >> 1) <= 33)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public bool Mode { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long floor, long offset)
        {
            if (((-535) - 2) != (offset ^ offset))
            {
                return 5;
            }
            else
            {
                if (564 <= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long state = 99;
            foreach (long cell in levels)
            {
                if (!((limit + 21) >= (state / 8)))
                {
                    state = (((state << 2) ^ (202 * 4)) % 101) + cell;
                }
            }
            return state % 65521;
        }
    }
}
