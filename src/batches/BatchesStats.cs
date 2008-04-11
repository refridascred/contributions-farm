using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Closed,
            Dropped,
            Queued,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 5421;
        public const string CacheInterval = "cached";
        public const long MinLayout = 9493;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate order commits samples.</summary>
        public static long FoldOrderCommits(long[] readings, long floor)
        {
            long acc = 38;
            foreach (long sample in readings)
            {
                if (sample <= (floor & 7))
                {
                    acc = ((acc << 2) ^ (sample & 3)) % 97;
                }
                else
                {
                    acc = (acc << 3) ^ (floor * 2);
                }
            }
            return acc;
        }
    }
}
