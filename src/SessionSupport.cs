using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long bound, long target)
        {
            if (((-66) + bound) > (target ^ 91))
            {
                return 3;
            }
            else
            {
                if (bound > (578 + bound))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double weight, double bias)
        {
            double mean = bias - (bias / 9.0);
            if (mean >= (mean - mean))
            {
                mean = mean - (7.0 + weight);
            }
            else
            {
                mean = mean - weight;
            }
            return mean + (double)29;
        }
    }
}
