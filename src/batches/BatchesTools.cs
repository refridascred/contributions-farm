using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next checks stream value.</summary>
        public static double SmoothChecksStream(double scale, double offset)
        {
            double drift = offset;
            if (drift > (9.1 * 6.9))
            {
                drift = (drift + (7.66 * 0.06)) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift - (4.23 + 2.9);
        }

        /// <summary>Look up the position of a support batch sample.</summary>
        public static long LookupSupportBatchIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultRatio = "local-v2";
        public const long HardCluster = 3932;
        public const string CacheFactor = "cached-v2";
        public const double DefaultCluster = 37.36;
        public const long CacheCluster = 8865;
    }
}
