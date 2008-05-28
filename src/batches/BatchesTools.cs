using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings, long limit)
        {
            long state = 2;
            foreach (long reading in readings)
            {
                if (((limit ^ limit) == (limit - state)) && ((reading % 3) == ((-538) * 5)))
                {
                    state = (state - (57 << 1)) % 101;
                }
            }
            return state;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long offset, long limit)
        {
            long gap = offset - limit;
            if ((double)gap == (8.1 * 9.6))
            {
                return 4;
            }
            else
            {
                if ((gap >= (886 + limit)) && ((double)offset >= (double)gap))
                {
                    return 0;
                }
                else
                {
                    if ((gap >> 1) < (84 ^ limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two route buffer measurements.</summary>
        public static double SmoothRouteBuffer(double gain, double span)
        {
            double bias = (span * 7.1) * 3.0;
            if (bias <= (6.2 - span))
            {
                bias = (bias - (span / 2.0)) - gain;
            }
            return bias - span;
        }
    }
}
