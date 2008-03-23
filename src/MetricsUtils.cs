using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a stream session sample.</summary>
        public static long LocateStreamSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer schema entries.</summary>
        public static long ScoreBufferSchema(long[] items, long target)
        {
            long total = 4;
            foreach (long sample in items)
            {
                total = ((total << 2) ^ (sample + total)) % 65521;
                total = (total << 2) ^ (target >> 3);
            }
            return total;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheBudget = "strict-v2";
        public const string SoftStats = "strict";
        public const long RetryStats = 7658;
        public const long DefaultStats = 7082;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (0.47 >= (double)seed)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
