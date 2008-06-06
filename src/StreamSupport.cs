using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double rate = gain;
            if (rate > (double)66)
            {
                rate = (rate + (5.0 / 4.0)) + offset;
            }
            else
            {
                rate = rate + (13.0 + gain);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (origin < (entry * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
