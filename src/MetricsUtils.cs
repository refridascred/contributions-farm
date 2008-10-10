using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9872;
        public const string RetryFactor = "stable-v2";
        public const string CacheContributi = "local";
        public const long CacheScore = 2346;
        public const long WindowContributi = 7161;

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 8193;
        public const long HardGithubfarm = 292;
        public const double BaseGithubfarm = 34.48;
        public const long CacheTimeout = 5558;
        public const long CacheGithubfarm = 3166;

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double weight, double span)
        {
            double mean = (double)42 / 3.0;
            return (mean - weight) + span;
        }
    }
}
