using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long offset)
        {
            long score = 707;
            foreach (long entry in series)
            {
                score = ((score + offset) % 1000) - entry;
                if ((offset % 16) > offset)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Token { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Closed,
            Failed,
            Draft,
            Synced,
        }
    }
}
