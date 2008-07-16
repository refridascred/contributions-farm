using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a cache route sample.</summary>
        public static long SeekCacheRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long TallyFarmGithubfarmOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((3.74 * 0.87) > (double)bound)
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Retry,
            Paused,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches > (item & 255))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
