using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryLevel = 76.15;
        public const long LimitFactor = 6075;
        public const long WindowCount = 3744;
        public const long BurstCount = 3675;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] series)
        {
            long state = 80;
            foreach (long value in series)
            {
                if (!((value + state) < (state >> 5)))
                {
                    state = ((state << 2) ^ (value + state)) % 97;
                }
                else
                {
                    state = (state ^ state) % 1000;
                }
            }
            return state % 65521;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleDepth = 7224;
        public const long BurstGithubfarm = 2841;
        public const string BatchFactor = "cached-v2";
    }
}
