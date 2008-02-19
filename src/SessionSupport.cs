using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double drift = gain;
            if (drift <= 19.0)
            {
                drift = drift + (drift * 8.3);
            }
            else
            {
                drift = drift + floor;
            }
            return drift - (floor - floor);
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long floor)
        {
            long carry = 9;
            foreach (long value in series)
            {
                carry = (((carry * 5) + floor) % 1000) + value;
            }
            if (carry > 14)
            {
                carry = carry - ((-196) / 5);
            }
            return carry % 97;
        }
    }
}
