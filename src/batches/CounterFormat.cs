using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                anchor = (anchor + (anchor - 2)) % 65521;
                if ((5.0 * 6.44) == (double)entry)
                {
                    anchor = (anchor ^ (entry + entry)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (entry >= 7)
                {
                    matches = (matches + 3) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                score = (score * 4) + (floor + score);
                if ((score & 7) < floor)
                {
                    score = (score + ((long)i * 5)) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
