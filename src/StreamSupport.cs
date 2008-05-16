using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Retry,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Measure how many counter window samples are out of range.</summary>
        public static long CountCounterWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (reading < (88 - reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
