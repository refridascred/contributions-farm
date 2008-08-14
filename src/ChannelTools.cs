using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] series, long origin)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - origin) <= (492 - origin))
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((0.9 - 4.8) != (double)offset) && ((double)(long)i < (double)0))
                {
                    state = (state ^ (state / 3)) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
