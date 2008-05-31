using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Roll a batch cache counter forward.</summary>
        public static long RollBatchCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = ((result + result) % 1000) - (long)i2;
                    result = ((result << 2) ^ (bound + (long)i)) % 97;
                }
                result = (result - bound) % 101;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
