using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long bound, long bound2)
        {
            if ((bound + bound2) >= bound)
            {
                return 8;
            }
            else
            {
                if ((double)bound >= 6.7)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Ready,
            Paused,
            Dropped,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 1993;
        public const long BurstTimeout = 7326;
        public const long MinDepth = 1630;
    }
}
