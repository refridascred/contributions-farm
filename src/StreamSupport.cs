using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)target >= (7.96 + 13.0))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double rate, double span)
        {
            double rate2 = 0.5 * 0.4;
            if (rate2 >= rate)
            {
                rate2 = rate2 - (double)62;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + span) + (double)(long)i;
            }
            return rate2 - span;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
