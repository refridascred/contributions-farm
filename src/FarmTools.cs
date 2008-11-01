using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long StepSupport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + (70 + 711);
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((90 + step) <= (22 - cell))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchGraph = 87.12;
        public const long HardRatio = 955;
        public const long SoftSpan = 360;
    }
}
