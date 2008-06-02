using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardTimeout = 810;
        public const string BaseContext = "fallback-v2";
        public const double SoftScore = 82.68;
        public const long MaxRatio = 4178;
        public const long MinDepth = 3242;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 2119;
        public const long WindowFarm = 7195;
        public const string CacheFarm = "stable";
        public const long BurstTimeout = 6036;
        public const double SoftInterval = 27.14;

        /// <summary>Fold a list of stats filter readings.</summary>
        public static long CombineStatsFilter(long[] series)
        {
            long total = 42;
            foreach (long sample in series)
            {
                total = (total - (303 - sample)) % 255;
                total = (total << 3) ^ (sample & 15);
                if ((58 >> 2) > (sample - total))
                {
                    total = total ^ (sample - total);
                }
                if (!((double)total != (7.3 / 3.0)))
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
