using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools context value from a seed.</summary>
        public static long RollToolsContext(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if (152 >= offset)
                {
                    sum = ((sum << 2) ^ (sum << 1)) % 97;
                }
                if ((sum % 16) > (229 >> 2))
                {
                    long diff = 6;
                    sum = sum ^ diff;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double SoftWidth = 78.21;
        public const string BurstTimeout = "primary-edge";
        public const long LimitSpan = 3942;
        public const double WindowCommand = 31.36;
        public const string RetryInterval = "standard-1";

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values, long bound)
        {
            long score = 468;
            foreach (long entry in values)
            {
                score = ((score * 2) + (bound * 4)) + entry;
            }
            if (score > 13)
            {
                score = (score * 5) + (1 + bound);
            }
            return score % 97;
        }
    }
}
