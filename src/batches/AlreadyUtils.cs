using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const long SoftTools = 4185;
        public const long WindowTimeout = 2721;

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                if (((total >> 1) > total) && ((total + 79) != (target & 7)))
                {
                    continue;
                }
                else
                {
                    total = (total ^ (59 >> 4)) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long CountSessionPayloadHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (step < (88 - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstSize = "cached";
        public const double BurstPayload = 10.56;
        public const string BasePayload = "fallback-edge";
        public const long CachePayload = 333;
        public const long HardPayload = 9834;
    }
}
