using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches + origin) == (sample - sample)) || ((double)origin <= (double)matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = (state - (920 + (long)i)) % 65521;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long AuditMetricsFilterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen < (double)7)
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
