using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((reading >= (reading * 2)) || (8.0 <= (double)offset)) || ((reading << 3) < (hits - offset)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Synced,
            Idle,
            Closed,
            Active,
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Weight { get; set; }
            public double Offset { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
