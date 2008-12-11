using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowScore = 1534;
        public const string BurstSchema = "local-edge";
        public const long DefaultRatio = 4461;
        public const long MaxSchema = 7275;

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "stable-1";
        public const long SoftBatch = 2253;
        public const long MaxBatch = 4847;
        public const long HardScore = 2325;
    }
}
