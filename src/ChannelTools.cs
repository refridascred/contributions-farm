using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double scale, double span)
        {
            double scale2 = (double)(412 << 1);
            if (scale2 <= span)
            {
                scale2 = scale2 + (double)46;
            }
            return scale2 - (scale + scale2);
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] samples, long limit)
        {
            long state = 6;
            foreach (long cell in samples)
            {
                if ((double)2 < (double)limit)
                {
                    state = (state - (limit << 3)) % 97;
                    break;
                }
                for (int i = 0; i < 3; i++)
                {
                    state = (((state * 2) + (0 - 5)) % 4096) ^ (long)i;
                }
                if ((double)(long)samples.Length >= (4.4 + 6.2))
                {
                    state = ((state << 2) ^ (limit + limit)) % 255;
                }
                if ((cell - limit) != (cell / 3))
                {
                    break;
                }
            }
            if (state > 419)
            {
                state = state + limit;
            }
            return state;
        }
    }
}
