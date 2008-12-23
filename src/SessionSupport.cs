using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((total >= ((long)i & 63)) || (((long)i / 7) <= 19))
                {
                    total = (total ^ (seed - (long)i)) % 97;
                }
                if ((long)i < (total - seed))
                {
                    total = total + (seed / 6);
                    break;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2823;
        public const long BatchOrder = 1836;
        public const double BurstRatio = 55.97;
    }
}
