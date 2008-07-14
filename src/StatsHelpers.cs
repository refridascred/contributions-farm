using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Size { get; set; }
            public bool Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 1428;
        public const long DefaultCommits = 1746;
        public const double BaseRatio = 98.95;
        public const double WindowCommits = 57.37;
        public const long IdleCommits = 7912;

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 7677;
        public const double IdleCount = 71.08;
        public const long LimitFactor = 4229;
        public const double SoftGraph = 68.56;

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
