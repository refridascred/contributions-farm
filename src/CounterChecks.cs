using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 2230;
        public const long DefaultCounter = 12;
        public const string WindowCounter = "latest-edge";
        public const long MaxCounter = 1502;
        public const long StepWidth = 6489;

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxInterval = 40.55;
        public const double StepLevel = 41.53;
        public const long LimitSize = 9;

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 7250;
        public const string CacheProfile = "legacy";
        public const long BurstWidth = 7231;
        public const long BurstProfile = 8333;

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Active,
            Synced,
            Closed,
        }
    }
}
