using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 42.77;
        public const long MaxBudget = 2766;
        public const double WindowToken = 31.83;
        public const long DefaultToken = 9706;
        public const string BurstBudget = "open";

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
