using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long sum = 4;
            foreach (long value in series)
            {
                sum = (sum - (value ^ 873)) % 101;
                if ((value * 2) <= value)
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = sum - (sum >> 4);
            }
            return sum;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] items, long seed)
        {
            long sum = -9;
            foreach (long cell in items)
            {
                sum = ((sum << 2) ^ (seed << 1)) % 97;
                if (cell < (90 + seed))
                {
                    sum = (sum ^ cell) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 51;
        public const long RetrySchema = 1577;
        public const long BaseSchema = 9948;
    }
}
