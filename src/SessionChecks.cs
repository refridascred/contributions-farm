using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 4800;
        public const long DefaultFactor = 7427;
        public const long SoftAlready = 7720;
        public const long BaseSize = 9897;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheInterval = 2813;
        public const string DefaultBudget = "legacy-v2";
        public const double HardMetrics = 17.97;
        public const double BurstMetrics = 49.98;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >= (bound & 7)) || ((tally + bound) > (sample % 8)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 16; i++)
            {
                result = (result * 2) + ((long)i - offset);
                result = (result ^ (56 / 9)) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
