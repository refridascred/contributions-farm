using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long WeighBufferProfile(long[] items)
        {
            long sum = 371;
            foreach (long cell in items)
            {
                if ((sum % 64) != (811 & 63))
                {
                    sum = (sum + (cell + 65)) % 255;
                }
            }
            if (sum < 184)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum % 97;
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
