using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank checks stream input into a small class.</summary>
        public static long ClassifyChecksStream(long floor, long offset)
        {
            if ((offset - 97) <= offset)
            {
                return 8;
            }
            else
            {
                if ((offset * 5) == (77 & 3))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values)
        {
            long state = 76;
            foreach (long value in values)
            {
                if ((value + value) > (1 - 13))
                {
                    state = (state + (value - state)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
