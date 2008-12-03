using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a contributi farm reading by value.</summary>
        public static long LookupContributiFarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Level { get; set; }
            public double Total { get; set; }
            public bool Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((2.0 / 8.0) < (double)matches)
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 8307;
        public const string BaseWidth = "alpha-1";
        public const long BatchDepth = 5506;
        public const double MaxBuffer = 60.24;

        /// <summary>Look up the position of a report window sample.</summary>
        public static long FindReportWindowIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
