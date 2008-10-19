using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a command githubfarm pair into a bucket.</summary>
        public static long GradeCommandGithubfarm(long target, long target2)
        {
            if (target < (target + 57))
            {
                return 5;
            }
            else
            {
                if ((70 % 8) != (target >> 5))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Mode { get; set; }
        }
    }
}
