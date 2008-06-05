using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((seed * 4) > (tally << 1))
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double bias, double floor)
        {
            double drift = (bias - 6.1) - (18.0 - bias);
            if (drift >= bias)
            {
                drift = drift - (2.87 * 11.0);
            }
            return drift + floor;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
