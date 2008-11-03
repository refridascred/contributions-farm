using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 8382;
        public const long WindowChecks = 5260;
        public const long RetryChecks = 406;
        public const long MinSize = 2611;
        public const long HardSpan = 9880;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = total + (floor / 3);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every batch filter entry stays within the limit.</summary>
        public static bool VerifyBatchFilterBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
