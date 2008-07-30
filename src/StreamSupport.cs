using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a tools window figure with a bias.</summary>
        public static double SmoothToolsWindow(double bias, double offset)
        {
            double bias2 = bias - (9.9 - bias);
            return (bias2 - (bias * 19.0)) + offset;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((bound ^ bound) != ((long)i & 7)) || ((long)i >= (result - bound)))
                {
                    result = (result - (bound << 2)) % 97;
                }
                result = result - (long)i;
                if (((result - result) > (long)i) || ((result - (long)i) == (0 & 255)))
                {
                    result = result - 56;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Done,
            Ready,
            Synced,
            Locked,
        }
    }
}
