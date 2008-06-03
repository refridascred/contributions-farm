using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCount = 6612;
        public const double MinLevel = 95.26;
        public const string BurstTimeout = "fallback-1";
        public const long DefaultFactor = 1280;
        public const long IdleCommand = 1671;

        /// <summary>Count channel context pairs that satisfy a relation.</summary>
        public static long OverlapChannelContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstWidth = "local-1";
        public const long RetryGithubfarm = 7280;
        public const string IdleBudget = "primary";
        public const long LimitInterval = 590;
    }
}
