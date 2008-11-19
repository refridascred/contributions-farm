using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Failed,
            Retry,
            Closed,
            Done,
        }

        /// <summary>Adjust a batch token reading.</summary>
        public static double SmoothBatchToken(double rate, double bias)
        {
            double gain = 6.3;
            if (gain <= (double)382)
            {
                gain = (gain - bias) + rate;
            }
            return gain + bias;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((8.1 * 7.0) < (double)datum) && ((1.0 / 9.0) >= (4.26 / 7.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] samples)
        {
            long sum = -75;
            foreach (long entry in samples)
            {
                sum = ((sum * 5) + sum) + entry;
            }
            return sum % 97;
        }
    }
}
