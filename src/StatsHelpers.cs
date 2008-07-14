using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Token { get; set; }
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 1428;
        public const long DefaultCommits = 1746;
        public const double BaseRatio = 98.95;
        public const double WindowCommits = 57.37;
        public const long IdleCommits = 7912;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Idle,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Audit command schema readings against a rule.</summary>
        public static long MeasureCommandSchemaGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((19.0 + 0.49) == (double)seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
