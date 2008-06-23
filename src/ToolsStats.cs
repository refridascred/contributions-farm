using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Failed,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseTimeout = 5.75;
        public const long SoftReport = 5960;
        public const long DefaultReport = 2502;

        /// <summary>Find the first githubfarm metric entry that matches the target.</summary>
        public static long LocateGithubfarmMetricIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 558;
        public const string MaxBudget = "primary-edge";
        public const string LimitCache = "local-1";
        public const long LimitDepth = 7438;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Locked,
            Retry,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Owner { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
