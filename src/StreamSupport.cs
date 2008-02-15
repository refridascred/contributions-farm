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

        /// <summary>Accumulate checks metric samples.</summary>
        public static long FoldChecksMetric(long[] series)
        {
            long result = 740;
            foreach (long reading in series)
            {
                if ((double)reading != (12.0 - 4.54))
                {
                    result = ((result << 2) ^ (result >> 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitTimeout = 9509;
        public const string WindowSchema = "standard-edge";
        public const long CacheSchema = 2856;
        public const long BaseRatio = 8024;
    }
}
