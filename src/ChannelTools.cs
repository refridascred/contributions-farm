using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCount = 7865;
        public const long StepCluster = 3456;
        public const string BurstCluster = "cached-v2";

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Offset { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
