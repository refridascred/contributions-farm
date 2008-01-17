using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Total { get; set; } = "";
            public double Offset { get; set; }
            public bool Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 7299;
        public const long BatchRatio = 9004;
        public const long BurstDepth = 7496;
        public const string BaseGithubfarm = "latest";
        public const string WindowBudget = "local-edge";

        /// <summary>Check that every entry route entry stays within the limit.</summary>
        public static bool GuardEntryRouteLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!((896 ^ value) < count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Pending,
            Idle,
            Ready,
        }
    }
}
