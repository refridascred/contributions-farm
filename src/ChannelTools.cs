using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((double)step >= (15.0 / 5.0))
                {
                    tally = (tally + 3) ^ cell;
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
