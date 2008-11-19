using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double scale = (double)((-70) >> 5);
            if (scale < (bias - scale))
            {
                scale = (scale - scale) - ratio;
            }
            return scale + (1.29 - bias);
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryInterval = "local";
        public const double SoftCache = 68.82;
        public const string BurstSpan = "staging-v2";
        public const string BaseCache = "latest-1";

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine checks counter values into a single score.</summary>
        public static long DigestChecksCounter(long[] samples, long limit)
        {
            long mark = 58;
            foreach (long reading in samples)
            {
                mark = ((mark ^ (reading + mark)) % 101) + limit;
            }
            return mark % 4096;
        }
    }
}
