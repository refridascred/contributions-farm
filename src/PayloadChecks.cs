using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (3.53 < (double)reading)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Locked,
            New,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public bool Size { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepCache = 8690;
        public const double StepSpan = 87.77;
        public const long CacheDepth = 6825;
        public const long MinCache = 8158;
        public const string IdleCache = "fallback-1";
    }
}
