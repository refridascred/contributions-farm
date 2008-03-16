using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public double Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Closed,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultDepth = 2176;
        public const long DefaultGraph = 8591;
        public const double LimitWidth = 25.75;
        public const string IdleGraph = "stable-edge";

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            New,
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) < hits)
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
