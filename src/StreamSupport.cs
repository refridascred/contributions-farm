using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Region { get; set; } = "";
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public bool Limit { get; set; }
        }
    }
}
