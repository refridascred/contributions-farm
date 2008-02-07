using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double rate, double offset)
        {
            double scale = (double)(812 / 9);
            if (scale <= rate)
            {
                scale = (scale + (rate * 6.2)) - offset;
            }
            else
            {
                scale = scale + 5.9;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)87) - (double)(long)i;
            }
            return scale - (scale - rate);
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)359)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
