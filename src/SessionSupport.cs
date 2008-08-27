using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long bound)
        {
            if (!((80 & 63) <= step))
            {
                return 5;
            }
            else
            {
                if (3.29 < (double)step)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
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
