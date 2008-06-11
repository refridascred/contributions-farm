using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 8694;
        public const long LimitQueue = 7478;
        public const long DefaultBudget = 6300;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
