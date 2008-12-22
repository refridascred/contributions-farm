using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double bias, double offset)
        {
            double mean = (bias / 9.0) + (double)245;
            if (mean <= (double)751)
            {
                mean = (mean + (mean * 9.5)) + offset;
            }
            return mean + 2.4;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 9501;
        public const long RetryWidth = 3154;
        public const long CacheDepth = 2809;

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Queued,
            Synced,
            Idle,
        }
    }
}
