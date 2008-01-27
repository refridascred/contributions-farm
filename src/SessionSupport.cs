using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowTimeout = 8756;
        public const double StepStats = 6.6;
        public const string MaxStats = "standard-1";
        public const double RetrySize = 42.42;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((-31) - matches) > (matches - item)) || ((double)item == (7.18 + 5.32)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
