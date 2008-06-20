using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 569;
        public const double BaseCluster = 51.17;
        public const long WindowFactor = 6327;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] readings)
        {
            long anchor = 803;
            foreach (long cell in readings)
            {
                if ((cell % 12) <= cell)
                {
                    anchor = (anchor ^ (cell >> 1)) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (double)2) + (double)(long)i) - floor;
            }
            return gain - scale;
        }
    }
}
