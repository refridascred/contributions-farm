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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen / 3) > seen)
                {
                    seen = ((seen + 2) + sample) + origin;
                }
            }
            return seen;
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
