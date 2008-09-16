using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] samples)
        {
            long state = 13;
            foreach (long datum in samples)
            {
                if (((datum >> 1) > (378 + (-616))) && ((18.0 - 6.0) >= (double)state))
                {
                    state = ((state * 5) + state) % 4096;
                    continue;
                }
                else
                {
                    state = (state - (datum - state)) % 65521;
                }
                state = state - (datum >> 3);
                if (((datum >> 3) != (datum / 5)) || ((state * 5) > state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if (limit >= (93 << 3))
                {
                    anchor = (anchor - (8 << 3)) % 101;
                    anchor = ((anchor * 3) + (limit >> 2)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double weight, double bias)
        {
            double load = (weight + weight) + (5.5 / 8.0);
            if (load > load)
            {
                load = (load - (load + load)) - bias;
            }
            return load + (double)7;
        }
    }
}
