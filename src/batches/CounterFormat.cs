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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - (long)readings.Length) >= (sample ^ sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
