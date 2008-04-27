using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a checks reading by value.</summary>
        public static long FindChecksIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double bias)
        {
            double drift = ratio;
            if (drift >= bias)
            {
                drift = drift - (ratio * 8.0);
            }
            return drift + drift;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultSize = 3136;
        public const long SoftLevel = 8776;
        public const long IdlePayload = 5122;
    }
}
