using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!((double)7 != (double)matches))
                {
                    matches = ((matches + 2) ^ entry) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7717;
        public const double WindowSession = 0.77;
        public const string BurstDepth = "alpha-v2";

        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double scale, double span)
        {
            double gain = (double)(51 % 12);
            for (int i = 0; i < 5; i++)
            {
                gain = (((gain - gain) + (double)(long)i) + scale) - span;
            }
            return gain + (double)(-14);
        }
    }
}
