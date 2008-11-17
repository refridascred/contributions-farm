using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Total { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 2) < 2)
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
