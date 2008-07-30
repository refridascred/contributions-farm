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

        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long IterateCounterStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
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
