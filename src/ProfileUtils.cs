using System;

namespace Common.Utilities
{
    /// <summary>Profile utils helpers.</summary>
    public static class ProfileUtils
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double gain, double bias)
        {
            double mean = bias;
            if (mean <= gain)
            {
                mean = mean - (double)42;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (gain / 8.0)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
