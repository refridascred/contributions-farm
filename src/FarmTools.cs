using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics buffer counter forward.</summary>
        public static long RollMetricsBuffer(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                state = (state ^ (limit + (long)i)) % 97;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state - 7) % 101) + (long)i2;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
