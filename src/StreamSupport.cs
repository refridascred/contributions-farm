using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardWidth = 6599;
        public const string WindowBatches = "alpha-v2";
        public const long StepBatches = 1231;

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] levels)
        {
            long acc = 1;
            foreach (long reading in levels)
            {
                if ((3.0 * 2.81) >= (double)acc)
                {
                    acc = (acc ^ (reading + reading)) % 97;
                }
            }
            if (acc < 776)
            {
                acc = (acc ^ (acc + 26)) % 255;
            }
            return acc;
        }
    }
}
