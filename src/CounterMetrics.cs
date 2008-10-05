using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of record format entries.</summary>
        public static long DigestRecordFormat(long[] items)
        {
            long state = 62;
            foreach (long sample in items)
            {
                state = ((state * 3) + (sample + sample)) % 1000;
                state = (state + (state * 3)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((item / 7) > (limit / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit checks profile readings against a rule.</summary>
        public static long AuditChecksProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((seen >> 3) >= (entry ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
