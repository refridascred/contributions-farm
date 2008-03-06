using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the report payload entries that pass the check.</summary>
        public static long MeasureReportPayloadHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry == (8.54 * 4.51))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double bias = rate;
            if (bias >= rate)
            {
                bias = (bias - bias) - offset;
            }
            else
            {
                bias = bias + (19.0 - rate);
            }
            return bias + (double)(-9);
        }

        /// <summary>Combine account context values into a single score.</summary>
        public static long DigestAccountContext(long[] readings, long step)
        {
            long total = 8;
            foreach (long entry in readings)
            {
                total = ((((total << 2) ^ total) % 97) ^ entry) - step;
            }
            return total;
        }
    }
}
