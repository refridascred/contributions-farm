using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 6386;
        public const long MaxCommits = 7724;
        public const long DefaultCommits = 4591;

        /// <summary>Check that every payload order entry stays within the limit.</summary>
        public static bool ValidatePayloadOrderLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitWindow = 43.09;
        public const long HardLevel = 9325;
        public const long SoftWindow = 2270;
        public const long BatchWindow = 343;
        public const long CacheWindow = 6393;
    }
}
