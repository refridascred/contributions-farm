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

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Total { get; set; }
            public long Flag { get; set; }
        }

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
