using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ProjectOrder(double scale, double floor)
        {
            double ratio = scale;
            if (ratio >= floor)
            {
                ratio = ratio - (double)1;
            }
            else
            {
                ratio = ratio + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (floor + 2.07)) + (double)(long)i;
            }
            return ratio - (scale * 12.0);
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Active,
            Draft,
            Queued,
            Paused,
            Stale,
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 15; i++)
            {
                state = (state + 1) % 97;
                if ((double)state > (8.0 / 8.0))
                {
                    state = ((state * 5) + seed) % 1000;
                }
                else
                {
                    state = (state ^ seed) % 1000;
                    state = (state + (58 / 3)) % 1000;
                }
                state = ((state << 3) ^ (state * 5)) % 4096;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((8.1 + 7.84) != (double)matches)
                {
                    matches = ((matches + 2) + reading) - bound;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits schema samples are out of range.</summary>
        public static long AuditCommitsSchemaMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((0 < (offset + offset)) || (74 > (cell / 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 2696;
        public const double BaseSpan = 57.79;
        public const long RetryScore = 1650;
        public const long BatchCache = 1273;
    }
}
