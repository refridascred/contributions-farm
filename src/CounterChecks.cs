using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitDepth = "latest-edge";
        public const double HardBudget = 38.22;
        public const double IdleInterval = 42.09;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepInterval = 9116;
        public const long IdleWindow = 5193;
        public const long BurstWindow = 1378;
        public const long HardWidth = 7575;
        public const string CacheLevel = "legacy-v2";

        /// <summary>Measure how many context contributi samples are out of range.</summary>
        public static long MeasureContextContributiOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item % 97) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheWidth = 3007;
        public const long IdlePayload = 1081;
        public const double BatchInterval = 94.24;
        public const long CachePayload = 7341;
        public const long SoftPayload = 3058;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample + hits) <= hits) || (6.8 >= (double)hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Limit { get; set; } = "";
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public long Owner { get; set; }
        }
    }
}
