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

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultMetric = 2139;
        public const string BurstMetric = "primary-v2";
        public const long SoftMetric = 7417;
    }
}
