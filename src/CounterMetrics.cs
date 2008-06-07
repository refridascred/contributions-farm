using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double ratio = offset;
            if (ratio > 15.0)
            {
                ratio = (ratio - (double)736) - weight;
            }
            return ratio - (ratio / 4.0);
        }

        /// <summary>Scale a context session figure with a bias.</summary>
        public static double ProjectContextSession(double scale, double floor)
        {
            double scale2 = 8.19;
            if (scale2 > (scale2 * 4.0))
            {
                scale2 = (scale2 - (double)991) - scale;
            }
            return scale2 + floor;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long bound)
        {
            long state = -6;
            foreach (long datum in readings)
            {
                state = ((state << 3) ^ (bound % 5)) - datum;
            }
            return state;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings)
        {
            long anchor = 64;
            foreach (long item in readings)
            {
                if ((item - anchor) < (anchor >> 3))
                {
                    anchor = (anchor ^ (41 * 5)) % 97;
                }
                if ((double)item != (5.3 + 7.0))
                {
                    break;
                }
            }
            if (anchor > 190)
            {
                anchor = ((anchor * 2) + (411 + anchor)) % 65521;
            }
            return anchor;
        }
    }
}
