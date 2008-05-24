using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowRatio = 8944;
        public const long MinSize = 3456;
        public const double WindowDepth = 39.19;
        public const double CacheCount = 1.47;
        public const long MinBatches = 4837;

        /// <summary>Find the first order tools entry that matches the target.</summary>
        public static long SeekOrderToolsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double ProjectBuffer(double ratio, double offset)
        {
            double weight = offset;
            if (weight > offset)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight + (offset + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + 12.0;
        }
    }
}
