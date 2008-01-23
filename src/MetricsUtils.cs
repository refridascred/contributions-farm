using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 8050;
        public const double LimitInterval = 71.55;
        public const long WindowSpan = 6842;
        public const long BurstLevel = 4876;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((entry / 3) < (seen + entry)) || ((seen & 1) <= (target % 10)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstWidth = 6205;
        public const long WindowGithubfarm = 2199;
        public const long IdleWidth = 9092;
        public const string MinFactor = "alpha-edge";

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
