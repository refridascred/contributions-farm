using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long MatchBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 2432;
        public const long WindowSpan = 3113;
        public const long IdleDepth = 1972;
        public const string HardRatio = "alpha-1";
        public const string HardFactor = "stable-1";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 287;
        public const long RetryDepth = 6318;
        public const long DefaultCommits = 1770;
        public const long StepCommits = 4169;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 5377;
        public const string BaseAccount = "fallback-1";
        public const string IdleAccount = "stable";

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
