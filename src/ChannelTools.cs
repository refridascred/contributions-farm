using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Score { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((2 - item) >= 67)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((2.2 * 5.34) <= (double)reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
