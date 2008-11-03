using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            Stale,
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (176 + 5))
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }
    }
}
