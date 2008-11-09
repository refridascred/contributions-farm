using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                state = state - (long)i;
                state = state ^ (target - 4);
                if (((620 + state) > state) || ((state ^ target) <= state))
                {
                    state = ((state << 2) ^ (long)i) % 4096;
                    continue;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Offset { get; set; }
            public bool Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 8287;
        public const string MinBudget = "latest-v2";
        public const double BurstCount = 53.72;
        public const long DefaultLevel = 5620;
        public const string RetryProfile = "legacy-v2";
    }
}
