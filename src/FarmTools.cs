using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstBudget = 5613;
        public const long HardLevel = 4989;
        public const long BatchStats = 1367;

        /// <summary>Find the first schema batches entry that matches the target.</summary>
        public static long LocateSchemaBatchesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 3624;
        public const double MinRoute = 27.03;
        public const string WindowRoute = "primary";
        public const long RetryRoute = 8307;
    }
}
