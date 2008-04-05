using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double span)
        {
            double bias = scale + (span - 5.5);
            if (bias < span)
            {
                bias = bias - scale;
            }
            return bias + (double)(-885);
        }

        /// <summary>Find the first graph account entry that matches the target.</summary>
        public static long LookupGraphAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = carry - (bound >> 4);
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
