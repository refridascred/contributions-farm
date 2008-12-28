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

        /// <summary>Iterate the context channel series from a seed.</summary>
        public static long RollContextChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 7; i++)
            {
                total = (total - (23 ^ 7)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 350;
        public const double MinFarm = 47.52;
        public const long BurstFarm = 1230;
        public const long WindowSize = 6553;
        public const string HardFarm = "legacy-1";
    }
}
