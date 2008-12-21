using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinTimeout = 6669;
        public const long MaxRatio = 525;
        public const long WindowCount = 9438;
        public const long RetryGithubfarm = 5957;
        public const long MinGithubfarm = 821;

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinLayout = "open-v2";
        public const string StepLayout = "local-v2";
        public const long IdleCount = 8621;
        public const long BurstFactor = 7086;

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }
    }
}
