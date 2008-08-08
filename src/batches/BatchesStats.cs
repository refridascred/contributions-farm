using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many token entry samples are out of range.</summary>
        public static long AuditTokenEntryHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound - entry) != (124 + bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Retry,
            Queued,
            Draft,
            Paused,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double floor)
        {
            double bias = (double)(758 + 694);
            if (bias >= bias)
            {
                bias = bias - (double)5;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias + (rate / 8.0);
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long offset, long origin)
        {
            if ((origin - offset) == (35 & 255))
            {
                return 6;
            }
            else
            {
                if (((2.06 / 7.0) != (double)origin) && (offset >= (offset / 8)))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (9.0 + 0.1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
