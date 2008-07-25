using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] data)
        {
            long total = 4;
            foreach (long entry in data)
            {
                if (((total + 87) >= (84 - total)) && ((total * 2) > (90 + entry)))
                {
                    total = total ^ entry;
                }
                if ((total * 5) >= (0 ^ total))
                {
                    break;
                }
            }
            if (total < 647)
            {
                total = ((total << 3) ^ (total + total)) % 255;
            }
            return total;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepTimeout = 7881;
        public const string DefaultEntry = "local";
        public const long LimitEntry = 2202;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 80.68;
        public const long HardSpan = 471;
        public const long BurstMetrics = 7004;
        public const long DefaultCount = 2394;
    }
}
