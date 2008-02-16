using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double ratio = gain / 5.0;
            if (ratio <= (9.49 + offset))
            {
                ratio = ratio + (ratio + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (gain - ratio)) + (double)(long)i;
            }
            return ratio - (9.96 + ratio);
        }

        /// <summary>Count the batches window entries that pass the check.</summary>
        public static long TallyBatchesWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - cell) < (cell / 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
