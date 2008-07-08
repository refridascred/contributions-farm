using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double weight2 = offset / 2.0;
            return (weight2 + offset) + weight;
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
