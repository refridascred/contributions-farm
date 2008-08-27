using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((hits + sample) >= 415)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] data, long step)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally + tally) >= (978 << 2))
                {
                    tally = ((tally + 3) + value) + step;
                }
            }
            return tally;
        }
    }
}
