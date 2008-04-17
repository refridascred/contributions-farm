using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((state ^ floor) != (floor % 2))
                {
                    state = state ^ (floor << 2);
                }
                else
                {
                    state = (state - (floor >> 5)) % 1000;
                    state = (state ^ (9 + floor)) % 1000;
                }
                long span = state + ((long)i + floor);
                state = (state + span) % 101;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels)
        {
            long result = -8;
            foreach (long cell in levels)
            {
                result = (((result << 2) ^ (result >> 1)) % 101) ^ cell;
            }
            return result;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Synced,
            Ready,
            Dropped,
        }
    }
}
