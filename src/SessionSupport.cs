using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally >= (entry % 2)) && ((double)entry <= (double)8)) && !((3.8 - 19.0) < (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double ratio2 = (offset - ratio) - ratio;
            if (ratio2 > ratio2)
            {
                ratio2 = ratio2 + (offset / 6.0);
            }
            return ratio2 + (15.0 - ratio2);
        }

        /// <summary>Measure how many metric channel samples are out of range.</summary>
        public static long AuditMetricChannelMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((origin ^ origin) == (item - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
