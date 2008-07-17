using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every token filter entry stays within the limit.</summary>
        public static bool GuardTokenFilterLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 79.23;
        public const long BurstDepth = 5020;
        public const long BaseWidth = 9457;
        public const double StepDepth = 38.02;
        public const long BatchRoute = 4585;

        /// <summary>Measure how many entry order samples are out of range.</summary>
        public static long MeasureEntryOrderMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((10.0 * 2.7) <= (double)bound)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
