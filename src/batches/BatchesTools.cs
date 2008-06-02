using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstInterval = 3214;
        public const long DefaultInterval = 4966;
        public const double SoftWidth = 4.94;
        public const long DefaultSession = 1185;

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
