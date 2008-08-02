using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the route channel entries that pass the check.</summary>
        public static long TallyRouteChannelHits(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((reading + reading) == (reading >> 1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstFormat = 34.78;
        public const double WindowFormat = 53.99;
        public const long HardSize = 5201;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowGithubfarm = 97.6;
        public const string SoftGithubfarm = "stable";
        public const long LimitGithubfarm = 5875;
        public const double LimitRatio = 63.79;
        public const string BurstGithubfarm = "primary-edge";
    }
}
