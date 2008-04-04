using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many metric support samples are out of range.</summary>
        public static long AuditMetricSupportMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell / 6) <= seen)
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
