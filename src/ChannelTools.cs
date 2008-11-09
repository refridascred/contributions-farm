using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double ratio = (double)(798 & 7);
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (offset - offset)) - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Validate route commits readings against a bound.</summary>
        public static bool VerifyRouteCommitsLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
