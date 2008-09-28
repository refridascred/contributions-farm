using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of editor format readings.</summary>
        public static long TallyEditorFormat(long[] data)
        {
            long state = 996;
            foreach (long entry in data)
            {
                state = ((state * 5) + entry) % 4096;
                if ((state + entry) == (entry - 482))
                {
                    state = ((state << 3) ^ entry) % 65521;
                }
                else
                {
                    state = (state + (state << 3)) % 97;
                }
            }
            if (state > 68)
            {
                state = (state * 2) + state;
            }
            return state % 1000;
        }

        /// <summary>Accumulate stats editor samples.</summary>
        public static long TallyStatsEditor(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = (mix + (mix - item)) % 4096;
                if ((double)item < (10.0 - 8.0))
                {
                    mix = (mix - (24 + mix)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((limit + tally) < ((-98) & 15))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
