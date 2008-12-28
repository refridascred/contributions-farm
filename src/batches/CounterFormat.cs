using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 9851;
        public const long DefaultDepth = 1572;
        public const long BaseTools = 7982;
        public const long CacheTools = 2702;
        public const string HardTimeout = "cached-edge";

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the batches queue series from a seed.</summary>
        public static long StepBatchesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                if (total <= (-390))
                {
                    continue;
                }
                if ((double)limit <= (19.0 - 9.6))
                {
                    total = (total ^ (-88)) % 255;
                    continue;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
