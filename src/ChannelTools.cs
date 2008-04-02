using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((18.0 - 19.0) >= (double)entry) || !((hits - 20) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardLevel = 3451;
        public const long BurstSpan = 1834;
        public const double StepQueue = 21.75;

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheSize = 1612;
        public const string WindowFarm = "local";
        public const long IdleFactor = 637;
        public const long MaxFarm = 7241;
        public const long BaseFarm = 1879;
    }
}
