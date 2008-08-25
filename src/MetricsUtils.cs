using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next buffer profile value.</summary>
        public static double BlendBufferProfile(double bias, double bias2)
        {
            double bias3 = (double)(25 >> 1);
            if (bias3 >= bias3)
            {
                bias3 = (bias3 + (bias / 8.0)) + bias2;
            }
            else
            {
                bias3 = bias3 + (double)54;
            }
            for (int i = 0; i < 5; i++)
            {
                bias3 = bias3 + (double)(long)i;
            }
            return bias3 - (bias3 / 7.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 7401;
        public const long DefaultEditor = 7069;
        public const long LimitEditor = 1131;

        /// <summary>Check that every githubfarm token entry stays within the limit.</summary>
        public static bool GuardGithubfarmTokenLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Paused,
            Done,
            Idle,
            Synced,
            Retry,
        }
    }
}
