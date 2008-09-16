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

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value >> 3) <= (value >> 4))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
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
