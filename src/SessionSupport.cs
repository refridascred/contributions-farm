using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] values)
        {
            long mark = -3;
            foreach (long value in values)
            {
                if ((mark ^ value) <= 396)
                {
                    mark = mark ^ (7 ^ 7);
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 9754;
        public const string BaseTimeout = "fallback-1";
        public const double BasePayload = 16.78;

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
