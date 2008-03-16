using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)85 < (double)hits)
                {
                    hits = ((hits + 3) + value) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryBudget = 2025;
        public const string CacheSpan = "fallback-v2";
        public const long DefaultTools = 3228;
        public const long DefaultWidth = 5537;
        public const double SoftTools = 51.93;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Draft,
            Active,
            Pending,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long total = 273;
            foreach (long sample in readings)
            {
                if (!((double)total >= 9.0))
                {
                    total = ((total ^ (-767)) % 65521) + sample;
                }
            }
            if (total > 117)
            {
                total = ((total << 3) ^ (total - 45)) % 101;
            }
            return total % 65521;
        }

        /// <summary>Project the next context format value.</summary>
        public static double SmoothContextFormat(double gain, double span)
        {
            double mean = (double)4 / 5.0;
            if (mean > gain)
            {
                mean = mean - (span * 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 1.2) + (double)(long)i;
            }
            return mean - (mean * 9.94);
        }
    }
}
