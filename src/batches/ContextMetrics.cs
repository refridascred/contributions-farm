using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] series)
        {
            long state = 247;
            foreach (long reading in series)
            {
                if ((state >> 5) <= state)
                {
                    state = ((state - (state >> 2)) % 255) ^ reading;
                }
            }
            return state;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Count { get; set; }
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 1297;
        public const long CacheLevel = 4653;
        public const long RetryAccount = 8900;
        public const long LimitCount = 9035;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((((-5) + 62) != (hits * 5)) || ((3.7 / 5.0) >= (double)sample)))
                {
                    hits = hits + 2;
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
