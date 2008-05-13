using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Done,
            Retry,
        }

        /// <summary>Audit editor stream readings against a rule.</summary>
        public static long TallyEditorStreamOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen + cell) != (seen ^ cell))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a contributi cluster sample.</summary>
        public static long LookupContributiClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepInterval = 7184;
        public const long BurstFilter = 1488;
        public const long DefaultRatio = 7378;
        public const long CacheTimeout = 9320;
        public const long MinWidth = 7684;
    }
}
