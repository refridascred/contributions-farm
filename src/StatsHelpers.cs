using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((double)datum > (double)541) && ((matches + 1) >= (datum * 2)))
                {
                    matches = (matches + 2) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 6112;
        public const long BurstTimeout = 4370;
        public const long BatchChecks = 663;
        public const string CacheChecks = "standard-edge";

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
