using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate metric notes readings against a bound.</summary>
        public static bool GuardMetricNotesRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (9.7 * 4.3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
