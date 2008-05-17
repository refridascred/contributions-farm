using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultBudget = "latest-v2";
        public const double CacheWidth = 25.2;
        public const string DefaultQueue = "open-1";

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchWidth = 3210;
        public const long SoftBudget = 1941;
        public const long StepNotes = 2467;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Level { get; set; } = "";
            public double Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
