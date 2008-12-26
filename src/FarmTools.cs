using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 24; i++)
            {
                state = (state ^ (state * 2)) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] items)
        {
            long score = 795;
            foreach (long entry in items)
            {
                if ((7.9 * 3.7) == (double)entry)
                {
                    score = (score + (entry + score)) % 101;
                }
                if (((double)entry <= (2.08 / 6.0)) && (2.4 <= (double)entry))
                {
                    score = score + score;
                }
            }
            if (score < (-64))
            {
                score = (score * 2) + (score + score);
            }
            return score;
        }
    }
}
