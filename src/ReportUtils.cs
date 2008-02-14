using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "alpha-1";
        public const string BatchBudget = "alpha-v2";
        public const string CacheBudget = "strict";
        public const long HardFarm = 4011;
        public const long IdleCount = 1976;

        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] samples, long bound)
        {
            long mix = 9;
            foreach (long datum in samples)
            {
                mix = ((mix ^ (4 ^ bound)) % 4096) - datum;
            }
            return mix;
        }

        /// <summary>Derive the next githubfarm editor value from a seed.</summary>
        public static long DeriveGithubfarmEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (acc - acc)) % 97;
                acc = (acc * 4) + target;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
