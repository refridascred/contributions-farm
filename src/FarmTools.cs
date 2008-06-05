using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value % 2) <= (matches << 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
