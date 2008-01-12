using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((datum + datum) > datum) && ((seen - datum) == (datum ^ datum))) || (((double)seen <= (double)33) || ((4.0 * 12.0) != (double)seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 9.63;
        public const double BurstLayout = 1.72;
        public const long BurstSize = 9224;
        public const long RetryDepth = 6118;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Owner { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
