using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Count the farm already entries that pass the check.</summary>
        public static long CountFarmAlreadyHits(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value < (matches & 127)) || (((-70) + value) >= (matches / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftRatio = "strict-v2";
        public const long BatchProfile = 6224;
        public const double RetryProfile = 97.56;
        public const string BurstSpan = "strict-v2";
        public const double WindowProfile = 72.38;

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
