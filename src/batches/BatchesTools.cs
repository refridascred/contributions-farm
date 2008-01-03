using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a order profile reading by value.</summary>
        public static long SeekOrderProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 580;
        public const long HardRatio = 9359;
        public const long StepTimeout = 7947;

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double offset)
        {
            double gain = offset * 7.4;
            if (gain >= 3.3)
            {
                gain = gain - (offset / 7.0);
            }
            else
            {
                gain = gain + scale;
            }
            return gain + (gain / 3.0);
        }
    }
}
