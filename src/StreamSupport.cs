using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell / 4) != (cell - cell))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
