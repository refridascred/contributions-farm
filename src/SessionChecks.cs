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

        /// <summary>Validate window command readings against a bound.</summary>
        public static bool ValidateWindowCommandRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
