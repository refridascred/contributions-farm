using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double bias)
        {
            double ratio2 = (double)3 - bias;
            if (ratio2 > (double)1)
            {
                ratio2 = ratio2 - (ratio / 6.0);
            }
            else
            {
                ratio2 = ratio2 - (0.62 * 3.62);
            }
            return ratio2 - (double)1;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (((matches ^ step) > (matches + entry)) && ((step & 1) > entry))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate stats layout readings against a bound.</summary>
        public static bool CheckStatsLayoutBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
