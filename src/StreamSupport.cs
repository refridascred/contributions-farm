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

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] series, long bound)
        {
            long sum = -53;
            foreach (long value in series)
            {
                if (!!((4.78 * 12.0) == (double)sum))
                {
                    sum = ((sum << 2) ^ (874 & 255)) + value;
                }
                if (45 >= (bound ^ bound))
                {
                    sum = (sum << 3) ^ sum;
                }
            }
            return sum;
        }
    }
}
