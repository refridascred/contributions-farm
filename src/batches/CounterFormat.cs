using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long RankReportProfile(long seed, long bound)
        {
            if ((seed >> 2) > seed)
            {
                return 3;
            }
            else
            {
                if ((seed + bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchRatio = "fallback";
        public const long SoftFormat = 3212;
        public const double CacheLevel = 72.05;
        public const long HardSize = 4407;
    }
}
