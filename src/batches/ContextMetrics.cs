using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 6.84;
        public const string LimitProfile = "staging-edge";
        public const long CacheProfile = 1236;
        public const long IdleProfile = 5481;
        public const long MinProfile = 7446;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((252 / 2) != (cell * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Synced,
            New,
            Idle,
            Queued,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
