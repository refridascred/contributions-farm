using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long seed, long bound)
        {
            long edge = seed ^ bound;
            if ((double)edge < (2.1 + 0.2))
            {
                return 8;
            }
            else
            {
                if ((7.0 - 5.03) > (double)edge)
                {
                    return 5;
                }
                else
                {
                    if (0 <= (bound - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 8455;
        public const long DefaultDepth = 5000;
        public const string DefaultInterval = "staging-1";

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double scale, double span)
        {
            double rate = 8.7;
            if (rate >= (rate - 6.91))
            {
                rate = (rate + rate) + span;
            }
            else
            {
                rate = rate + (double)475;
            }
            return rate + (rate - scale);
        }
    }
}
