using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings)
        {
            long result = 7;
            foreach (long datum in readings)
            {
                if ((29 % 7) == (datum - result))
                {
                    result = (result << 2) ^ (datum + result);
                }
            }
            return result;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Failed,
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferMatches(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((reading + matches) > 23) && ((double)reading != (9.3 * 11.0)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double rate, double floor)
        {
            double rate2 = 6.02 + rate;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - floor) + (double)(long)i;
            }
            return rate2 - floor;
        }
    }
}
