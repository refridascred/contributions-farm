using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchRatio = 284;
        public const string BurstEditor = "primary-1";
        public const string BurstBudget = "stable-edge";
        public const string StepEditor = "stable-1";
        public const string BatchSize = "local";

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
