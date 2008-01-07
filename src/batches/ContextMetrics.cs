using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstProfile = 6.84;
        public const string LimitProfile = "staging-edge";
        public const long CacheProfile = 1236;
        public const long IdleProfile = 5481;
        public const long MinProfile = 7446;

        /// <summary>Define session limits and defaults.</summary>
        public const string LimitTimeout = "staging-v2";
        public const long BaseScore = 7959;
        public const long BatchDepth = 7184;
        public const string CacheLevel = "stable-1";

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((252 / 2) != (cell * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the metric stats series from a seed.</summary>
        public static long RollMetricStats(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
