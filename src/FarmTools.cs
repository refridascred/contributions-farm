using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Locked,
            Draft,
            New,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardLevel = 7522;
        public const string DefaultOrder = "stable-edge";
        public const double HardOrder = 16.73;
        public const long StepOrder = 4093;
        public const long SoftSpan = 7503;

        /// <summary>Locate a entry metric reading by value.</summary>
        public static long LocateEntryMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
