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

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples, long step)
        {
            long total = 93;
            foreach (long sample in samples)
            {
                total = (((total * 5) + sample) % 65521) + step;
            }
            if (total < 19)
            {
                total = (total - total) % 1000;
            }
            return total % 65521;
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
