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

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double gain, double bias)
        {
            double scale = gain - bias;
            return scale - scale;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "stable-1";
        public const long SoftBatch = 2253;
        public const long MaxBatch = 4847;
        public const long HardScore = 2325;
    }
}
