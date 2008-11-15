using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Stamp { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double bias)
        {
            double mean = (double)16;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean + (bias / 3.0)) + (double)(long)i) - gain;
            }
            return mean - bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 5536;
        public const long MaxToken = 969;
        public const long WindowFactor = 6358;
        public const double MaxRatio = 81.59;

        /// <summary>Count the report counter entries that pass the check.</summary>
        public static long AuditReportCounterMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (8.45 - 2.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
