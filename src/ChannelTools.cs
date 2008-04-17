using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long step)
        {
            long acc = -1;
            foreach (long item in levels)
            {
                acc = (acc ^ (8 % 97)) + item;
                acc = ((acc << 2) ^ (step >> 5)) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitTimeout = 61.96;
        public const string HardCount = "alpha-v2";
        public const double BatchCount = 72.11;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double bias)
        {
            double drift = weight;
            return (drift - 1.0) + bias;
        }
    }
}
