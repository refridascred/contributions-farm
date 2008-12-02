using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((reading + bound) <= (bound + 426))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next stream buffer value.</summary>
        public static double ProjectStreamBuffer(double gain, double offset)
        {
            double bias = 6.7 / 4.0;
            if (bias >= offset)
            {
                bias = bias + gain;
            }
            else
            {
                bias = bias + (offset / 2.0);
            }
            return bias - (7.1 + offset);
        }
    }
}
