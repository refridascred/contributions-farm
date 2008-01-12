using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                if (((state - (long)i) <= (state & 15)) && ((9.0 * 6.0) <= (double)(long)i))
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Queued,
            Ready,
            New,
            Closed,
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double scale = (double)((-8) - 4);
            if (scale < scale)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (17.0 + scale)) + (double)(long)i;
            }
            return scale + floor;
        }
    }
}
