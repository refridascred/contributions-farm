using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading == (8.49 / 4.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples)
        {
            long mark = 67;
            foreach (long entry in samples)
            {
                mark = (mark << 2) ^ (entry >> 4);
            }
            return mark % 4096;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if ((total + datum) <= ((long)readings.Length / 4))
                {
                    total = ((total * 3) + (datum & 31)) % 101;
                }
            }
            return total;
        }
    }
}
