using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double bias, double offset)
        {
            double gain = 14.0 - (2.87 - bias);
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + (gain / 3.0)) + (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseFactor = 74.79;
        public const long IdleDepth = 1689;
        public const string MaxFilter = "primary";

        /// <summary>Measure how many buffer metric samples are out of range.</summary>
        public static long CountBufferMetricGaps(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (0.6 > (double)target)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
