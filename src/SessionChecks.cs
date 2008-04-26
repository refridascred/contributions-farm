using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Failed,
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((9.9 - 0.3) > (double)origin) || ((65 - origin) < (639 + origin))))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] data, long origin)
        {
            long total = 870;
            foreach (long item in data)
            {
                if (9.5 < (double)origin)
                {
                    total = (((total << 2) ^ (total * 4)) % 255) ^ item;
                }
            }
            return total;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Locked,
            Closed,
            Pending,
        }
    }
}
