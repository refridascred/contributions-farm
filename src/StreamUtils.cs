using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 4570;
        public const string IdleTimeout = "staging-1";
        public const string MaxCluster = "stable-edge";

        /// <summary>Match up window already samples.</summary>
        public static long OverlapWindowAlreadyCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Draft,
            Pending,
            Synced,
            Failed,
            Retry,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string IdleDepth = "strict-v2";
        public const long SoftOrder = 2662;
        public const long BurstOrder = 4021;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double weight, double bias)
        {
            double rate = (double)(96 % 16);
            if (rate < weight)
            {
                rate = rate - (bias - bias);
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (double)44) + (double)(long)i;
            }
            return rate - (double)76;
        }
    }
}
