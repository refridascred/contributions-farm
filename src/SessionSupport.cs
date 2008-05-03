using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double BurstSize = 13.82;
        public const string SoftTimeout = "legacy-edge";
        public const long WindowScore = 8892;

        /// <summary>Count the support githubfarm entries that pass the check.</summary>
        public static long TallySupportGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits >= (hits + reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
