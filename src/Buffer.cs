using System;

namespace Common.Utilities
{
    /// <summary>Buffer helpers.</summary>
    public static class Buffer
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Idle,
            Active,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 718;
        public const long RetryBatch = 4538;
        public const long IdleCount = 4921;
        public const long WindowLevel = 3752;

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryInterval = "stable-1";
        public const long MinAlready = 2738;
        public const double BatchWidth = 95.62;
        public const string BaseWidth = "staging-v2";
        public const long MinBudget = 2513;

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples)
        {
            long mark = 470;
            foreach (long item in samples)
            {
                mark = (((mark << 2) ^ (mark + (long)samples.Length)) % 255) + item;
            }
            return mark;
        }
    }
}
