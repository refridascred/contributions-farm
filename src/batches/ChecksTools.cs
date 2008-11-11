using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) < (entry >> 3)) || ((matches >> 2) != (8 - matches))))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats context entry stays within the limit.</summary>
        public static bool VerifyStatsContextBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum - (-40)) > (tally >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the counter farm series from a seed.</summary>
        public static long RollCounterFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 14; i++)
            {
                state = (state ^ (state & 127)) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
