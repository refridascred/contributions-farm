using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the checks entry entries that pass the check.</summary>
        public static long TallyChecksEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)matches > (4.1 * 6.8))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 4466;
        public const string IdleCache = "legacy-1";
        public const long StepCache = 5358;
        public const long BurstCache = 6370;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double rate2 = rate;
            return (rate2 - (rate2 * 4.87)) + floor;
        }
    }
}
