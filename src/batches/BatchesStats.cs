using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleLevel = 90.83;
        public const string MaxRatio = "staging";
        public const string MinStats = "latest-v2";
        public const long MaxScore = 654;
        public const string DefaultStats = "legacy-v2";

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultFactor = 9794;
        public const string WindowRatio = "cached-v2";
        public const long DefaultInterval = 7805;
        public const long LimitSize = 3878;
    }
}
