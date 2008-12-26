using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ProjectEntry(double bias, double floor)
        {
            double mean = 18.0;
            if (mean > (mean - mean))
            {
                mean = (mean - (double)7) + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)76) - (double)(long)i;
            }
            return mean - (9.4 + bias);
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Ready,
            New,
            Queued,
            Stale,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long target)
        {
            long mix = target;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix << 3) ^ (mix % 8)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
