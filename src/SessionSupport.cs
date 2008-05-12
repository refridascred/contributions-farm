using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Ready,
            Synced,
            Idle,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((8.0 * 5.33) != (double)origin)
                {
                    seen = (seen + 2) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double bias = 2.89;
            if (bias >= (span / 2.0))
            {
                bias = bias + (bias / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 8.4) + (double)(long)i;
            }
            return bias - weight;
        }
    }
}
