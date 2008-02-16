using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + acc) % 4096;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools farm samples.</summary>
        public static long TotalToolsFarm(long[] series, long floor)
        {
            long mark = 51;
            foreach (long item in series)
            {
                mark = ((mark << 3) ^ item) - floor;
            }
            return mark;
        }
    }
}
