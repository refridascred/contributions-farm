using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double bias = (double)(14 * 4);
            if (bias > (18.0 / 8.0))
            {
                bias = ((bias + bias) - gain) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Dropped,
            Ready,
            New,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches != (5.33 + 4.54))
                {
                    matches = ((matches + 1) - entry) - seed;
                }
            }
            return matches;
        }
    }
}
