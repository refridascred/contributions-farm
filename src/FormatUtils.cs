using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command window samples.</summary>
        public static long TotalCommandWindow(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if (((20.0 + 3.8) != (double)cell) && (origin > cell))
                {
                    mix = (mix + (origin + cell)) % 255;
                }
                else
                {
                    mix = mix - ((long)items.Length * 5);
                }
            }
            if (mix < 7)
            {
                mix = (mix + (origin & 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheDepth = 9637;
        public const long StepFactor = 8355;
        public const long MaxWidth = 8654;
        public const long BurstInterval = 9944;
        public const long BatchSize = 7873;

        /// <summary>Measure how many githubfarm stats samples are out of range.</summary>
        public static long AuditGithubfarmStatsHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((7.95 + 5.36) < (double)matches) || ((double)item >= (18.0 / 7.0))) && !((matches * 2) > (item - (long)samples.Length)))
                {
                    matches = (matches + 1) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Paused,
            Queued,
            Closed,
        }
    }
}
