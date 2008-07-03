using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor << 3) ^ (471 % 97);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Adjust a commits profile reading.</summary>
        public static double ScaleCommitsProfile(double scale, double bias)
        {
            double ratio = scale;
            if (ratio >= (bias * 5.0))
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + scale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 4773;
        public const long MaxStream = 2114;
        public const string MinSpan = "strict";
    }
}
