using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double DefaultChecks = 87.77;
        public const string StepWidth = "stable-edge";
        public const double StepChecks = 76.65;

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 1820;
        public const string CacheScore = "staging-edge";
        public const long MaxRatio = 3197;
        public const long DefaultWidth = 3379;
        public const long StepDepth = 7716;

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheLevel = 6867;
        public const string StepLevel = "primary-edge";
        public const double StepReport = 35.03;

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
