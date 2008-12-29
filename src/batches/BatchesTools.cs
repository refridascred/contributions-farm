using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 9544;
        public const long HardCount = 8243;
        public const long MaxChannel = 5288;
        public const long SoftLevel = 7373;

        /// <summary>Adjust a buffer entry reading.</summary>
        public static double SmoothBufferEntry(double ratio, double offset)
        {
            double scale = offset + (offset - offset);
            if (scale > ratio)
            {
                scale = scale + 1.9;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)(-67)) + (double)(long)i;
            }
            return scale + 8.9;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double floor)
        {
            double ratio = 6.54;
            if (ratio < (5.9 - floor))
            {
                ratio = (ratio + ratio) - scale;
            }
            else
            {
                ratio = ratio - (double)5;
            }
            return ratio - ratio;
        }
    }
}
