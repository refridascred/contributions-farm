using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session context samples are out of range.</summary>
        public static long TallySessionContextHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(count <= (count - count)))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
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
