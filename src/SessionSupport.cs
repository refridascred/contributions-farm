using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Offset { get; set; }
            public bool Region { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long step, long bound)
        {
            long edge = step ^ bound;
            if ((950 - edge) <= (step + edge))
            {
                return 0;
            }
            else
            {
                if ((bound + step) > edge)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double mean = (double)850 + 6.0;
            if (mean > bias)
            {
                mean = mean - bias;
            }
            else
            {
                mean = mean + (rate * 1.2);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - bias) - (double)(long)i;
            }
            return mean + (double)8;
        }
    }
}
