using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum ^ seen) > seen) || (datum < (datum & 127)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxInterval = 9744;
        public const long StepScore = 2089;
        public const long CacheAccount = 4473;
        public const string MinAccount = "legacy";
        public const long RetrySize = 7156;

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
