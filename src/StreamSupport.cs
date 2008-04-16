using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of order batch readings.</summary>
        public static long WeighOrderBatch(long[] levels)
        {
            long state = 870;
            foreach (long datum in levels)
            {
                state = state ^ (25 % 64);
                if ((320 >= (datum + 606)) && ((datum - 2) != (state + 827)))
                {
                    state = (state - datum) % 1000;
                }
                if (!((double)datum <= (9.7 + 6.4)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double scale = 7.4;
            if (scale > (bias - bias))
            {
                scale = (scale - scale) + gain;
            }
            return scale + bias;
        }
    }
}
