using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a cluster already reading by value.</summary>
        public static long LookupClusterAlreadyIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryInterval = 27.59;
        public const long MinQueue = 4240;
        public const long RetryQueue = 7805;
        public const string BurstSpan = "staging";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (196 < (cell >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
