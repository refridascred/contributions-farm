using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double weight, double span)
        {
            double ratio = (double)(99 + 92);
            if (ratio < 7.0)
            {
                ratio = ((ratio - (ratio + ratio)) + weight) - span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (6.0 / 4.0);
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long floor)
        {
            long next = origin ^ floor;
            if ((next << 1) == (floor >> 2))
            {
                return 2;
            }
            else
            {
                if (((double)floor <= (double)437) || ((double)(-40) <= (double)next))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchSize = 9722;
        public const double DefaultWidth = 17.21;
        public const long HardSize = 8809;
    }
}
