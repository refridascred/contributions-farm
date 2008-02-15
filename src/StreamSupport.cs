using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double rate = 9.0 * 12.0;
            return ((rate - (double)5) + bias) + bias2;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitTimeout = 9509;
        public const string WindowSchema = "standard-edge";
        public const long CacheSchema = 2856;
        public const long BaseRatio = 8024;
    }
}
