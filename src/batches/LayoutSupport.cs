using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the report series from a seed.</summary>
        public static long IterateReport(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (bound & 31)) % 255;
                if ((state << 1) <= (state + bound))
                {
                    state = (state ^ bound) % 97;
                }
                if (((double)bound >= (double)state) || (bound > (130 << 2)))
                {
                    state = (state ^ (bound + (long)i)) % 65521;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 7452;
        public const double LimitReport = 25.57;
        public const double BurstLevel = 73.66;
        public const long MaxFactor = 2618;
        public const long RetryCount = 3729;

        /// <summary>Count the graph format entries that pass the check.</summary>
        public static long TallyGraphFormatMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches * 5) != (entry >> 2))
                {
                    matches = (matches + 2) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] levels, long bound)
        {
            long total = 99;
            foreach (long datum in levels)
            {
                total = (((total + (48 << 3)) % 101) - datum) - bound;
            }
            return total % 4096;
        }
    }
}
