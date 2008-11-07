using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)floor < (8.62 - 7.7)))
                {
                    mix = ((mix * 5) + floor) % 65521;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((tally / 6) == (191 << 3))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = state - (origin % 60);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
