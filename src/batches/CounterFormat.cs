using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchScore = 1768;
        public const string WindowDepth = "stable-v2";
        public const long WindowSize = 7325;
        public const long BatchBatches = 4978;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public bool Limit { get; set; }
        }
    }
}
