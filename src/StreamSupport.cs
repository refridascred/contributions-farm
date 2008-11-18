using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit checks graph readings against a rule.</summary>
        public static long MeasureChecksGraphGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample * 3) < (sample - matches)) || (((sample * 4) == (matches << 2)) || ((double)sample < (double)matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double bias = scale;
            return (bias - (double)7) + span;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] values, long seed)
        {
            long state = 24;
            foreach (long datum in values)
            {
                state = (state - (state & 31)) + datum;
            }
            if (state < (-70))
            {
                state = (state + (seed % 60)) % 255;
            }
            return state % 4096;
        }
    }
}
