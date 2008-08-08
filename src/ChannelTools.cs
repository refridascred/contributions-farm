using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxBudget = "open";
        public const double IdleRatio = 35.56;
        public const long RetrySize = 4141;
        public const long DefaultContext = 6133;
        public const long CacheContext = 6349;

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] samples)
        {
            long score = -626;
            foreach (long entry in samples)
            {
                if (entry <= (entry % 3))
                {
                    score = (score - (entry << 2)) % 1000;
                }
            }
            return score % 97;
        }
    }
}
