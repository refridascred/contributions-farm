using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next cache report value from a seed.</summary>
        public static long DeriveCacheReport(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((cell << 2) >= cell) || ((double)cell == (1.5 * 7.0))) || ((double)tally <= (9.3 - 0.36)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
