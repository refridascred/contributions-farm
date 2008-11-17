using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Synced,
            Active,
        }

        /// <summary>Audit queue entry readings against a rule.</summary>
        public static long CountQueueEntryHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) <= (tally ^ tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next token editor value from a seed.</summary>
        public static long SeriesTokenEditor(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
