using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels, long step)
        {
            long result = 84;
            foreach (long cell in levels)
            {
                result = (((result ^ result) % 65521) + cell) - step;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 3292;
        public const long MaxLevel = 3094;
        public const long MaxFarm = 3026;
        public const long BurstSpan = 2608;

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowRatio = 89.82;
        public const string RetryTimeout = "alpha";
        public const long MaxCount = 1798;
        public const double RetryRatio = 62.7;
        public const double RetrySession = 73.54;
    }
}
