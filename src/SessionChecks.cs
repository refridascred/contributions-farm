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

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double SmoothNotes(double bias, double offset)
        {
            double scale = (double)48 - (bias - offset);
            if (scale <= scale)
            {
                scale = scale - (bias * 20.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + offset) + (double)(long)i;
            }
            return scale - bias;
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
