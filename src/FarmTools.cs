using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                if (2.81 < (double)(long)i)
                {
                    break;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
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
