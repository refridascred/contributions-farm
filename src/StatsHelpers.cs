using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowBudget = 2197;
        public const string SoftDepth = "fallback-1";
        public const long BatchSupport = 1668;
        public const long CacheTimeout = 5357;
        public const double StepTimeout = 81.77;

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "standard-v2";
        public const long WindowEntry = 8362;
        public const double MaxEntry = 57.7;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
        }
    }
}
