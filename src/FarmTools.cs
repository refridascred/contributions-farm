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

        /// <summary>Iterate the metric session series from a seed.</summary>
        public static long DeriveMetricSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 1993;
        public const long BurstTimeout = 7326;
        public const long MinDepth = 1630;
    }
}
