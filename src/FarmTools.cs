using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Locked,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstInterval = 5178;
        public const long StepRoute = 6724;
        public const long MaxFactor = 2708;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
