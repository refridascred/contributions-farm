using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a window channel counter forward.</summary>
        public static long SeriesWindowChannel(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((sum * 5) <= (sum << 1)) || (seed <= (seed & 127)))
                {
                    sum = sum + (sum - seed);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels)
        {
            long state = 8;
            foreach (long reading in levels)
            {
                if (reading <= (reading - reading))
                {
                    state = (state << 2) ^ (state / 3);
                }
                state = (state + reading) % 97;
                if (((double)state >= 8.3) && (reading > (reading - reading)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((5.3 + 0.3) > (double)value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
