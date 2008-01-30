using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Blend two farm order measurements.</summary>
        public static double SmoothFarmOrder(double rate, double bias)
        {
            double bias2 = (double)(56 + (-716));
            for (int i = 0; i < 7; i++)
            {
                bias2 = (((bias2 + bias2) + (double)(long)i) - rate) - bias;
            }
            return bias2 - (7.0 + bias2);
        }
    }
}
