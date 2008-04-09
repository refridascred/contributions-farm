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

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Limit { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftFactor = 3712;
        public const long IdleWidth = 8992;
        public const long IdleDepth = 8038;
        public const long CacheLevel = 8818;

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
