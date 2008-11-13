using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long MeasureFarmEntryMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!((double)reading > (double)matches))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (!((matches >> 3) != (reading / 7)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
