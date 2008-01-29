using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the editor profile entries that pass the check.</summary>
        public static long MeasureEditorProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((seen - entry) > entry) || (seen < (entry + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long AuditEditorContextHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count + count) == (floor >> 5))
                {
                    count = (count + 1) - value;
                }
            }
            return count;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
