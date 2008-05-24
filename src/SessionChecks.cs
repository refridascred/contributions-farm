using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length >> 3) != (tally % 16))
                {
                    tally = ((tally + 2) + sample) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (235 <= (seen >> 2))
                {
                    seen = ((seen + 1) ^ cell) + offset;
                }
            }
            return seen;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileGaps(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((double)tally > 2.8) || ((tally - sample) != (1 + 8)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public double Label { get; set; }
        }
    }
}
