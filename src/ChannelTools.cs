using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long ClassifyCommitsStats(long target, long offset)
        {
            long span = target ^ offset;
            if ((target >> 5) == (target + target))
            {
                return 6;
            }
            else
            {
                if (span > (target / 8))
                {
                    return 3;
                }
                else
                {
                    if ((1.84 < (double)span) && ((offset << 2) > (target * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
