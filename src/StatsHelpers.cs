using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Done,
            Queued,
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + 5) % 65521;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "legacy-edge";
        public const double MaxFilter = 37.0;
        public const long MinFilter = 326;
        public const string StepFilter = "stable";
        public const double CacheSize = 80.05;

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Active,
            Locked,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
            public double Total { get; set; }
        }
    }
}
