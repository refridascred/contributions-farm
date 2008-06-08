using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double rate, double floor)
        {
            double ratio = floor;
            if (ratio < (double)33)
            {
                ratio = (ratio - (floor * 6.7)) + rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio - (9.75 / 6.0);
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate account support samples.</summary>
        public static long TallyAccountSupport(long[] samples)
        {
            long carry = -281;
            foreach (long datum in samples)
            {
                carry = ((carry << 2) ^ (carry << 1)) - datum;
            }
            return carry;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long AuditToolsReportHits(long[] series, long step)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((14.0 + 2.1) != (double)count)
                {
                    count = ((count + 1) + entry) + step;
                }
            }
            return count;
        }
    }
}
