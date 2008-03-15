using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading - reading) == (origin / 6)) || (((hits * 4) >= (hits << 1)) && ((hits - reading) != (origin - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Paused,
            Done,
            Idle,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultSpan = 2468;
        public const long IdleReport = 3740;
        public const long BurstFactor = 3741;

        /// <summary>Define tools limits and defaults.</summary>
        public const long SoftRatio = 2257;
        public const long BaseRatio = 7886;
        public const long BaseTools = 149;
        public const long LimitLevel = 4441;
        public const long RetryDepth = 8000;

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Paused,
            Stale,
        }
    }
}
