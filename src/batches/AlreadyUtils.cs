using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Limit { get; set; } = "";
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Failed,
            Paused,
            Stale,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] levels)
        {
            long sum = 55;
            foreach (long value in levels)
            {
                if ((value + 59) < (41 + sum))
                {
                    sum = ((sum * 5) + (35 >> 3)) % 1000;
                }
                else
                {
                    sum = (sum << 3) ^ (sum + value);
                }
            }
            if (sum < 22)
            {
                sum = ((sum * 2) + (1 % 100)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate batches checks readings against a bound.</summary>
        public static bool GuardBatchesChecksLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
