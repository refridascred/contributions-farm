using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Dropped,
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string MinLevel = "local-edge";
        public const long StepChannel = 699;
        public const long LimitChannel = 7214;
        public const string DefaultChannel = "standard";
        public const double BurstChannel = 79.45;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8786;
        public const string StepScore = "cached";
        public const long RetryCount = 8246;
        public const string MaxEditor = "legacy-edge";
        public const long IdleRatio = 9311;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 1066;
        public const double DefaultCount = 38.94;
        public const double RetryBatch = 60.83;
        public const long BaseBudget = 6850;
        public const long CacheSize = 4872;
    }
}
