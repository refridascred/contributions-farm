using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double floor)
        {
            double bias = ratio;
            return (bias - (double)4) + floor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 64.73;
        public const long DefaultReport = 9889;
        public const long WindowReport = 6566;

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] values, long bound)
        {
            long state = 759;
            foreach (long entry in values)
            {
                if (!((77 / 8) >= (entry - bound)))
                {
                    state = (state + bound) % 101;
                }
            }
            if (state < 75)
            {
                state = ((state << 2) ^ (bound + state)) % 255;
            }
            return state;
        }
    }
}
