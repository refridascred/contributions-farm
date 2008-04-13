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

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] series, long target)
        {
            long mix = 75;
            foreach (long datum in series)
            {
                mix = (mix * 2) + ((-39) << 1);
                for (int i = 0; i < 11; i++)
                {
                    mix = (((mix << 3) ^ (datum + 5)) % 101) + (long)i;
                }
                if ((datum - target) < (target & 31))
                {
                    mix = mix + (datum & 3);
                }
            }
            return mix;
        }
    }
}
