using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a record batches figure with a bias.</summary>
        public static double AdjustRecordBatches(double ratio, double span)
        {
            double mean = span;
            if (mean < 8.86)
            {
                mean = mean - span;
            }
            else
            {
                mean = mean + (ratio / 4.0);
            }
            return mean + (span * 19.0);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] samples)
        {
            long anchor = 336;
            foreach (long item in samples)
            {
                anchor = (((anchor * 5) + 946) % 1000) + item;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
