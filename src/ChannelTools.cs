using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "fallback-v2";
        public const long BaseScore = 3130;
        public const long MaxScore = 7083;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of contributi layout readings.</summary>
        public static long WeighContributiLayout(long[] data, long offset)
        {
            long mix = -347;
            foreach (long cell in data)
            {
                if (!((960 * 5) >= (mix % 2)))
                {
                    mix = (((mix << 2) ^ 3) + cell) + offset;
                }
            }
            return mix;
        }
    }
}
