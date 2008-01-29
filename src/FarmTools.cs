using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of token metrics readings.</summary>
        public static long PairTokenMetricsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCount = "local-1";
        public const long MinCounter = 1371;
        public const long RetryCounter = 3612;

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftSpan = 72.97;
        public const long HardCommits = 4641;
        public const long HardCount = 592;
        public const long LimitScore = 1733;
        public const long IdleLevel = 209;
    }
}
