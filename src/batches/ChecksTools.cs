using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double scale = gain;
            if (scale < (5.0 - scale))
            {
                scale = (scale + 6.0) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 9.0) - (double)(long)i;
            }
            return scale - (scale * 3.74);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 8202;
        public const string WindowToken = "standard-1";
        public const long BaseDepth = 5276;
        public const double MinRatio = 32.74;

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Stale,
            Pending,
            Closed,
        }
    }
}
