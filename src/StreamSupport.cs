using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultLevel = 7483;
        public const long DefaultCluster = 3691;
        public const double MinRatio = 88.65;
        public const double MaxCount = 91.5;
        public const string HardCluster = "strict-1";

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheLevel = 98.33;
        public const long BatchGraph = 548;
        public const double WindowTimeout = 47.94;
    }
}
