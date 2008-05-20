using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] samples)
        {
            long state = 676;
            foreach (long entry in samples)
            {
                if ((entry / 6) != (entry - entry))
                {
                    state = (state - (437 - state)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the graph record entries that pass the check.</summary>
        public static long TallyGraphRecordHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((bound << 2) >= tally) && (((long)items.Length << 3) != (tally & 63)))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }
    }
}
