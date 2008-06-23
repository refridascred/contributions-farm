using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long offset)
        {
            long score = 19;
            foreach (long cell in series)
            {
                score = ((score + (offset & 15)) % 255) ^ cell;
            }
            if (score < (-1))
            {
                score = (score << 3) ^ (offset ^ score);
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 389;
        public const double BurstFormat = 9.79;
        public const long WindowSpan = 4187;
        public const long LimitFormat = 5350;

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Idle,
            Pending,
            Queued,
            Closed,
        }
    }
}
