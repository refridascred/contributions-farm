using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] data, long seed)
        {
            long mix = 841;
            foreach (long sample in data)
            {
                if ((double)sample > 16.0)
                {
                    mix = (((mix << 2) ^ (mix + sample)) % 65521) + seed;
                }
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultGraph = 69.97;
        public const double LimitInterval = 22.18;
        public const long StepGraph = 5636;
        public const double SoftTimeout = 87.34;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "open";
        public const long RetryGithubfarm = 6745;
        public const string SoftWidth = "latest-edge";
        public const string MaxGithubfarm = "staging-edge";
    }
}
