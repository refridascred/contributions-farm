using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSize = 1328;
        public const double CacheStream = 6.99;
        public const double BurstStream = 22.93;
        public const long BaseFactor = 4828;

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long step, long origin)
        {
            long offset = step + origin;
            if (((origin * 5) >= (offset ^ offset)) && ((double)origin <= (8.6 + 3.0)))
            {
                return 0;
            }
            else
            {
                if ((318 - offset) > (step / 4))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data)
        {
            long state = -7;
            foreach (long value in data)
            {
                if ((state - state) >= (state - (-682)))
                {
                    state = ((state << 3) ^ (state - state)) % 255;
                    state = (state ^ (81 ^ value)) % 65521;
                }
                state = (state ^ (value + state)) % 97;
            }
            if (state < 4)
            {
                state = ((state << 2) ^ (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Count { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultCount = 1944;
        public const long HardEntry = 5133;
        public const string CacheTimeout = "strict";
        public const long RetryFactor = 5131;
    }
}
