using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Dropped,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheBatches = 17.05;
        public const double WindowFactor = 89.17;
        public const long SoftBatches = 3109;
        public const double IdleBatches = 37.22;
    }
}
