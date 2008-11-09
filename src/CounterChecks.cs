using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Mode { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Stale,
            Active,
            Ready,
            Idle,
            Done,
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Stale,
            Retry,
            New,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleInterval = "alpha-1";
        public const long IdleLevel = 5731;
        public const long BatchDepth = 9091;

        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "cached-edge";
        public const long DefaultCommits = 9403;
        public const long SoftCommits = 1749;
        public const double HardRatio = 21.87;
        public const long MinLevel = 7297;
    }
}
