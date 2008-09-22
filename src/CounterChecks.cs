using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((-17) < (item >> 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepTimeout = 621;
        public const string LimitCache = "cached-v2";
        public const long HardWidth = 1090;
        public const long MinInterval = 7708;

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
