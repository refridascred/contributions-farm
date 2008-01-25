using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Done,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultWidth = "open-1";
        public const long CacheWidth = 954;
        public const double MaxBudget = 38.83;

        /// <summary>Find the first schema cluster entry that matches the target.</summary>
        public static long LocateSchemaClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values, long limit)
        {
            long total = 96;
            foreach (long item in values)
            {
                total = (((total + (68 + total)) % 65521) ^ item) + limit;
            }
            return total % 1000;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = rate;
            return load + offset;
        }
    }
}
