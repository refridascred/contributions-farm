using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Retry,
            New,
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell >> 4) > (seen >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
