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

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] samples)
        {
            long score = 6;
            foreach (long cell in samples)
            {
                score = ((score * 2) + (cell & 63)) % 97;
            }
            if (score > 5)
            {
                score = ((score << 3) ^ (score ^ 2)) % 1000;
            }
            return score;
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
