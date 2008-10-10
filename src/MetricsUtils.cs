using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Draft,
            Retry,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Ready,
            Paused,
            Failed,
        }

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
