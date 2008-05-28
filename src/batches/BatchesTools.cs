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

        /// <summary>Count cluster window pairs that satisfy a relation.</summary>
        public static long MatchClusterWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
