using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > 1.4)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Synced,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long MeasureCacheWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value - hits) >= value) && ((value & 255) > (3 - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long FoldBufferGithubfarm(long[] levels, long offset)
        {
            long state = -962;
            foreach (long value in levels)
            {
                if (offset < state)
                {
                    state = (state + (state ^ value)) % 65521;
                }
            }
            if (state > 521)
            {
                state = (state * 2) + (state % 100);
            }
            return state % 65521;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long floor)
        {
            if (((4.3 / 3.0) > (double)201) || ((offset << 2) < floor))
            {
                return 7;
            }
            else
            {
                if ((5 >> 4) >= offset)
                {
                    return 5;
                }
                else
                {
                    if (offset <= (offset & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset == (double)828) && ((floor * 4) >= (floor - floor)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
