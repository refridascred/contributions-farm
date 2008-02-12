using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Failed,
            New,
            Stale,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 9979;
        public const long BurstSize = 1078;
        public const double RetryFactor = 1.76;
        public const string RetryAccount = "open";
        public const long StepAccount = 3847;

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double bias, double offset)
        {
            double drift = bias;
            if (drift >= (drift + drift))
            {
                drift = drift - offset;
            }
            return drift + (bias / 7.0);
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = (((carry << 3) ^ ((long)i + origin)) % 101) - (long)i2;
                    carry = (carry + (carry / 9)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Owner { get; set; }
        }
    }
}
