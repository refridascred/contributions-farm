using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LookupEntryIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Total { get; set; } = "";
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count the editor report entries that pass the check.</summary>
        public static long AuditEditorReportMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((3.8 + 6.0) >= (double)seen)
                {
                    seen = ((seen + 2) ^ entry) - floor;
                }
            }
            return seen;
        }
    }
}
