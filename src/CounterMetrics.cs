using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSpan = 474;
        public const long MaxSpan = 8724;
        public const long MinNotes = 9780;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen >> 4) < (item - (long)samples.Length))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            Draft,
            Dropped,
            Queued,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell * 4) < (seed + 180)) && !((806 + cell) > (seed + tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
