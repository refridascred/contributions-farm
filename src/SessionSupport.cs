using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] readings)
        {
            long state = 8;
            foreach (long sample in readings)
            {
                if ((1 * 3) <= state)
                {
                    state = ((state * 4) + ((long)readings.Length & 255)) % 255;
                }
                if ((state >= 463) || ((double)state >= (double)sample))
                {
                    break;
                }
            }
            return state;
        }
    }
}
