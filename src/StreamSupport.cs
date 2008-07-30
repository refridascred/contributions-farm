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

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i <= floor)
                {
                    anchor = (anchor << 2) ^ (floor - anchor);
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
