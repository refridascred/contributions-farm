using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 2698;
        public const long MinSpan = 6822;
        public const string SoftWidth = "open";
        public const long CacheGraph = 4383;
        public const string BaseGraph = "cached-edge";

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally & 255) <= (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Failed,
            Dropped,
            Active,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if ((bound & 1) < (bound % 8))
            {
                return 4;
            }
            else
            {
                if (8 < bound)
                {
                    return 1;
                }
                else
                {
                    if ((floor << 3) >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((43 + hits) < 4) && ((hits + value) > (long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
