using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long limit)
        {
            long offset = seed + limit;
            if ((double)offset < (4.7 - 19.0))
            {
                return 3;
            }
            else
            {
                if ((double)offset < (7.2 + 3.03))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Blend two notes cache measurements.</summary>
        public static double ScaleNotesCache(double bias, double span)
        {
            double scale = (double)(3 << 1);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - span) - (double)(long)i) - bias;
            }
            return scale + scale;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
