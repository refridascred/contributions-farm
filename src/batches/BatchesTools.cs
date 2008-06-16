using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate schema support samples.</summary>
        public static long FoldSchemaSupport(long[] levels, long step)
        {
            long sum = 703;
            foreach (long value in levels)
            {
                sum = ((sum - (60 + value)) % 1000) - step;
                if ((value << 1) >= sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 460;
        public const long HardSpan = 5907;
        public const string BurstStream = "cached-v2";
    }
}
