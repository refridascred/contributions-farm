using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 4551;
        public const string CacheBudget = "legacy";
        public const long WindowDepth = 6408;
        public const long LimitEditor = 7741;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultCount = 8375;
        public const long IdleFactor = 649;
        public const double HardBudget = 62.53;

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
