using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate editor report readings against a bound.</summary>
        public static bool CheckEditorReportRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Closed,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 350;
        public const double MinFarm = 47.52;
        public const long BurstFarm = 1230;
        public const long WindowSize = 6553;
        public const string HardFarm = "legacy-1";
    }
}
