using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a cache farm reading by value.</summary>
        public static long FindCacheFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 4910;
        public const long SoftBatch = 6323;
        public const string BatchSpan = "open-edge";
        public const string MinBatch = "cached";

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long offset, long floor)
        {
            long gap = offset ^ floor;
            if ((gap + floor) >= gap)
            {
                return 7;
            }
            else
            {
                if ((gap % 2) <= gap)
                {
                    return 8;
                }
                else
                {
                    if (gap > floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
