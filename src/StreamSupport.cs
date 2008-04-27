using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings, long bound)
        {
            long result = 57;
            foreach (long datum in readings)
            {
                result = result + (result >> 3);
                if ((result ^ result) == (result >> 2))
                {
                    result = (result * 5) + (bound + datum);
                }
            }
            return result;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheSpan = 3615;
        public const long SoftSpan = 8716;
        public const long BurstRatio = 1153;
        public const long DefaultBatches = 166;

        /// <summary>Blend two buffer githubfarm measurements.</summary>
        public static double AdjustBufferGithubfarm(double gain, double offset)
        {
            double mean = (double)170 / 4.0;
            if (mean < (mean - gain))
            {
                mean = (mean + mean) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)1) - (double)(long)i;
            }
            return mean - (double)714;
        }
    }
}
