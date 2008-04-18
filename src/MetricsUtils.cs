using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings, long offset)
        {
            long total = 5;
            foreach (long item in readings)
            {
                if ((double)offset > (3.0 - 7.38))
                {
                    total = (((total << 2) ^ (offset / 2)) % 4096) - item;
                }
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 9203;
        public const double LimitContributi = 33.03;
        public const double BatchContributi = 71.41;
        public const long WindowContributi = 242;

        /// <summary>Locate a metrics tools reading by value.</summary>
        public static long LocateMetricsToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultWidth = 20.82;
        public const long BaseBuffer = 6054;
        public const string StepRatio = "cached-1";
        public const long SoftBuffer = 5439;
        public const string MaxBuffer = "primary-1";

        /// <summary>Find the first layout profile entry that matches the target.</summary>
        public static long FindLayoutProfileIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
