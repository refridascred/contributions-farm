using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 8186;
        public const long CacheFarm = 3358;
        public const long HardSize = 8708;
        public const string DefaultFactor = "local-v2";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((8.26 + 3.0) <= (double)item) || (((matches % 100) >= (item % 12)) || ((1.4 - 7.6) > (double)item)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 6573;
        public const long DefaultEntry = 4960;
        public const long IdleEntry = 5707;
        public const long BatchEntry = 1992;
        public const long SoftLevel = 7844;
    }
}
