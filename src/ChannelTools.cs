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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 487;
        public const string IdleFactor = "cached";
        public const long BaseInterval = 4758;
        public const long LimitCluster = 5856;
    }
}
