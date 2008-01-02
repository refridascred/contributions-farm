using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (!!((cell % 60) < matches))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }
    }
}
