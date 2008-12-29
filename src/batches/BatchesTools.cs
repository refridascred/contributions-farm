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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches - matches) <= matches)
                {
                    matches = (matches + 2) - item;
                }
            }
            return matches;
        }
    }
}
