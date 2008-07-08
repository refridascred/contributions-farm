using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 18;
            foreach (long sample in series)
            {
                if ((0 > acc) || ((sample >> 5) < (sample >> 2)))
                {
                    acc = (acc << 3) ^ (8 & 1);
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit contributi metrics readings against a rule.</summary>
        public static long MeasureContributiMetricsGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((-7) & 7) < tally)
                {
                    tally = ((tally + 3) - sample) + offset;
                }
            }
            return tally;
        }
    }
}
