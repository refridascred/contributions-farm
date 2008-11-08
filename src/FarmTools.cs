using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double weight, double offset)
        {
            double bias = weight;
            if (bias <= offset)
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - 4.0) + (double)(long)i;
            }
            return bias + (bias * 3.5);
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the checks filter entries that pass the check.</summary>
        public static long AuditChecksFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)465 == (double)hits)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }
    }
}
