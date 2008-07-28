using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 9726;
        public const double RetrySpan = 42.78;
        public const long BaseChannel = 7488;
        public const double BurstChannel = 68.08;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Offset { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series)
        {
            long score = -476;
            foreach (long cell in series)
            {
                score = ((score ^ 6) % 4096) + cell;
            }
            return score % 65521;
        }
    }
}
