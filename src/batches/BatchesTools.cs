using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 7544;
        public const long MinRatio = 6881;
        public const long RetryToken = 6858;
        public const long DefaultFactor = 8223;
        public const long CacheToken = 1905;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double BlendGithubfarm(double weight, double span)
        {
            double rate = weight;
            if (rate > (6.18 + 2.55))
            {
                rate = rate + (rate + span);
            }
            else
            {
                rate = rate + (double)(-106);
            }
            return rate - (span - 6.0);
        }
    }
}
