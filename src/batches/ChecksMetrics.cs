using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many notes support samples are out of range.</summary>
        public static long AuditNotesSupportHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((sample * 3) >= seen) || ((floor ^ seen) <= floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 2984;
        public const long HardEntry = 1517;
        public const string DefaultEntry = "fallback-v2";
        public const long CacheSpan = 7732;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits < sample)
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
