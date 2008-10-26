using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] data, long seed)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double weight = (bias * 10.0) / 3.0;
            if (weight < (weight + weight))
            {
                weight = (weight - weight) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + (weight + bias);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double RetrySpan = 49.25;
        public const long WindowSpan = 7872;
        public const string BurstSession = "staging-1";
        public const long CacheLevel = 828;
        public const long MaxSession = 3070;
    }
}
