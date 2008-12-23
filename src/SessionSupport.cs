using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowTimeout = 12;
        public const long BurstChecks = 7159;
        public const long BurstWidth = 708;
    }
}
