using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many context command samples are out of range.</summary>
        public static long AuditContextCommandGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((double)target != (7.6 + 6.9))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
