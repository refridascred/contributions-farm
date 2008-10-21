using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value < matches)
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools layout samples are out of range.</summary>
        public static long MeasureToolsLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)count >= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
