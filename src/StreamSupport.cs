using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long CountClusterReportGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) != (sample % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheCount = 1.65;
        public const long LimitFormat = 9621;
        public const long MaxSpan = 4763;
        public const string RetryFormat = "alpha-v2";
    }
}
