using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit checks entry readings against a rule.</summary>
        public static long MeasureChecksEntryOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!!(entry <= (tally ^ tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of farm payload entries.</summary>
        public static long CombineFarmPayload(long[] items, long target)
        {
            long mark = -3;
            foreach (long entry in items)
            {
                if (target <= (entry >> 1))
                {
                    mark = (mark + (entry >> 1)) % 4096;
                }
                if ((target + entry) < (mark - 493))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = mark ^ mark;
            }
            return mark % 97;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
