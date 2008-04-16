using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double bias)
        {
            double gain = 7.65;
            if (gain <= (1.59 * 1.43))
            {
                gain = (gain - (gain * 8.0)) - bias;
            }
            return gain + (0.31 + ratio);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item + item) >= item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
