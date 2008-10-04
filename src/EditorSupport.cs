using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= target)
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

        /// <summary>Audit counter buffer readings against a rule.</summary>
        public static long CountCounterBufferOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!!(bound > (count << 1)))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
