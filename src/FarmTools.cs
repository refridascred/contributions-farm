using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheDepth = 8242;
        public const double BurstBatches = 53.93;
        public const long HardFactor = 8279;

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Offset { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
