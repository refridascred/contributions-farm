using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the graph route entries that pass the check.</summary>
        public static long CountGraphRouteOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((29 - tally) != (bound & 63)) && (reading < (long)series.Length)) && ((169 / 6) < tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long seed)
        {
            long sum = 787;
            foreach (long datum in levels)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (((sum << 2) ^ sum) % 101) ^ (long)i2;
                }
                if (((double)(long)levels.Length >= 7.9) || ((2.78 + 13.0) <= (double)datum))
                {
                    sum = (sum - (seed * 2)) % 1000;
                }
                else
                {
                    sum = ((sum << 3) ^ (seed - datum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultScore = 5999;
        public const long IdleReport = 786;
        public const double DefaultReport = 25.34;
    }
}
