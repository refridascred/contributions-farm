using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally % 16) <= (947 / 8))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Draft,
            Locked,
            Failed,
            New,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Count the buffer schema entries that pass the check.</summary>
        public static long MeasureBufferSchemaGaps(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((0.3 + 1.4) >= (double)step)
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double scale, double span)
        {
            double load = 2.0 * 3.1;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (span - span)) + (double)(long)i) - scale;
            }
            return load + (span / 4.0);
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
