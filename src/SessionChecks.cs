using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next buffer stream value from a seed.</summary>
        public static long DeriveBufferStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 9; i++)
            {
                if (((-925) - anchor) >= 269)
                {
                    continue;
                }
                else
                {
                    anchor = (anchor - ((-26) ^ anchor)) % 65521;
                }
                if (!((double)anchor == (6.15 / 9.0)))
                {
                    anchor = (anchor * 3) + 385;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Synced,
            Stale,
            Idle,
        }

        /// <summary>Project the next metric value.</summary>
        public static double ScaleMetric(double rate, double span)
        {
            double gain = (double)(20 << 3);
            if (gain < (gain / 3.0))
            {
                gain = (gain - (double)893) + span;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - (rate / 7.0);
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - count) <= (92 + count))
                {
                    count = (count + 2) + seed;
                }
            }
            return count;
        }
    }
}
