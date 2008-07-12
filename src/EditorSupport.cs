using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long acc = -98;
            foreach (long value in series)
            {
                if ((value - acc) != (value & 7))
                {
                    acc = acc + (acc * 2);
                }
                else
                {
                    acc = (acc * 3) + (value ^ (long)series.Length);
                }
                if ((10.0 / 2.0) < (double)value)
                {
                    break;
                }
            }
            if (acc < 258)
            {
                acc = acc - (acc / 4);
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 43.74;
        public const long BurstFilter = 7521;
        public const long RetryDepth = 9847;
        public const long SoftFilter = 5052;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long StepLevel = 1317;
        public const string DefaultScore = "legacy";
        public const long MinStream = 5069;
    }
}
