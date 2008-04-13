using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((9.2 * 12.0) < (double)value)
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] data)
        {
            long mix = -33;
            foreach (long datum in data)
            {
                if (((mix + mix) < datum) || (mix <= (987 + datum)))
                {
                    mix = (mix ^ (mix - mix)) % 97;
                }
                if ((mix >> 4) < (mix / 2))
                {
                    break;
                }
            }
            if (mix > 223)
            {
                mix = (mix - (mix >> 4)) % 65521;
            }
            return mix;
        }
    }
}
