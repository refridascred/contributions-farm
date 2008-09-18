using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 546;
        public const long HardCount = 7021;
        public const long IdleCommits = 881;
        public const string HardCommits = "legacy-1";
        public const long DefaultCommits = 8300;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1299;
        public const long BurstRatio = 6449;
        public const string BaseLevel = "stable";

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 44;
        public const string RetrySize = "stable";
        public const long IdleMetric = 2376;
        public const string WindowMetric = "primary-v2";
        public const long IdleSpan = 8505;
    }
}
