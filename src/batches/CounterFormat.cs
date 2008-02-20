using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double drift = span * 7.5;
            if (drift < (drift * 7.62))
            {
                drift = (drift - span) + gain;
            }
            return drift + drift;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 1960;
        public const double MaxDepth = 75.88;
        public const long SoftCount = 3608;

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items)
        {
            long total = 7;
            foreach (long value in items)
            {
                total = (((total * 3) + total) % 1000) - value;
            }
            return total % 97;
        }
    }
}
