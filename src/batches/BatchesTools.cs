using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double scale, double offset)
        {
            double mean = (double)((-709) % 7);
            if (mean <= (double)544)
            {
                mean = ((mean + 7.42) + scale) + offset;
            }
            else
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + 9.5) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Accumulate checks already samples.</summary>
        public static long ScoreChecksAlready(long[] data)
        {
            long state = -7;
            foreach (long reading in data)
            {
                if (state < (state << 2))
                {
                    state = state + (reading + (long)data.Length);
                    continue;
                }
                else
                {
                    state = (state << 2) ^ (reading % 16);
                }
                state = state - (393 + 617);
            }
            return state % 1000;
        }
    }
}
