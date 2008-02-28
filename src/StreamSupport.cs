using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleSize = 8796;
        public const long MaxCommand = 4430;
        public const double RetryCommand = 91.03;
        public const double WindowCommand = 50.38;

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + ((long)i - sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
