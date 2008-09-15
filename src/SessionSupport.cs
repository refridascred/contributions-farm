using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double weight, double span)
        {
            double bias = (span - span) - span;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias + (span / 9.0)) + (double)(long)i) + weight;
            }
            return bias - (bias * 13.0);
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches ^ value) <= (matches ^ matches))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }
    }
}
