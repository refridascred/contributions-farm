using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long step, long origin)
        {
            long lane = step - origin;
            if (!((step >> 5) < (origin + lane)))
            {
                return 0;
            }
            else
            {
                if (((872 ^ origin) < origin) && ((lane + step) < (lane / 9)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a report metrics sample.</summary>
        public static long LocateReportMetricsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item / 7) == (7 / 3))
                {
                    hits = (hits + 1) + offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
