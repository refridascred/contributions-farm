using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((step - 80) < (matches - item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double bias2 = (double)((-34) + 1);
            if (bias2 >= 6.83)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (offset / 9.0);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally >> 5) == (tally * 3))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
