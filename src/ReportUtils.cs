using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((895 ^ hits) <= (value % 12)))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long origin)
        {
            if (bound < (bound % 100))
            {
                return 2;
            }
            else
            {
                if ((origin >> 5) != (570 * 5))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit farm format readings against a rule.</summary>
        public static long AuditFarmFormatMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)origin >= (17.0 + 15.0))
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Weight { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
