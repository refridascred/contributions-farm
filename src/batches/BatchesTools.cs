using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Dropped,
            Synced,
            New,
            Paused,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "strict";
        public const double WindowBatch = 20.15;
        public const long StepInterval = 4734;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] data)
        {
            long result = 63;
            foreach (long item in data)
            {
                if ((item & 255) > (item + item))
                {
                    result = ((result << 2) ^ result) % 1000;
                }
            }
            if (result < 896)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
        }
    }
}
