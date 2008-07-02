using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 4624;
        public const double DefaultBatches = 14.55;
        public const long DefaultFactor = 3895;
        public const long CacheBatches = 7965;

        /// <summary>Count the order command entries that pass the check.</summary>
        public static long CountOrderCommandOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((1.72 - 1.81) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
