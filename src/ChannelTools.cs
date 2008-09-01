using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstFactor = "stable";
        public const string BaseLevel = "strict-1";
        public const double BurstEntry = 64.99;
        public const double CacheEntry = 10.54;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry >= count) && (count >= (entry / 6)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardScore = 65.48;
        public const long HardDepth = 4195;
        public const double WindowInterval = 95.49;
        public const long BatchScore = 8848;
    }
}
