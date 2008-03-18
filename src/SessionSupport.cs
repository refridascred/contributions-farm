using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell <= (hits % 3)) || ((double)cell < (double)10))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a farm contributi figure with a bias.</summary>
        public static double ProjectFarmContributi(double bias, double bias2)
        {
            double ratio = 8.8;
            if (ratio >= (double)188)
            {
                ratio = ((ratio + (double)(-290)) - bias) + bias2;
            }
            return ratio + ratio;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double ratio, double span)
        {
            double gain = 4.76 * 3.52;
            if (gain <= (span - span))
            {
                gain = (gain - (gain - gain)) - ratio;
            }
            return gain - (gain + 6.22);
        }
    }
}
