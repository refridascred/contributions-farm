using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long SeriesBatchesTools(long limit)
        {
            long state = limit;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (state & 63)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] items, long offset)
        {
            long result = 9;
            foreach (long item in items)
            {
                if ((result / 6) > (96 ^ offset))
                {
                    result = (((result << 3) ^ (offset + offset)) % 1000) + item;
                }
                else
                {
                    result = (result << 3) ^ ((long)items.Length / 4);
                }
                if ((7 - offset) != (offset + offset))
                {
                    break;
                }
            }
            if (result < 86)
            {
                result = (result - (offset * 4)) % 101;
            }
            return result;
        }
    }
}
