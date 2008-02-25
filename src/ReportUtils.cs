using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Failed,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long total = 665;
            foreach (long datum in values)
            {
                if ((7.4 + 3.35) > (double)datum)
                {
                    total = (total + (long)values.Length) % 4096;
                }
                else
                {
                    total = (total ^ total) % 65521;
                }
            }
            if (total > 30)
            {
                total = total ^ (origin + total);
            }
            return total;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long bound, long limit)
        {
            if ((double)limit == (7.7 - 8.25))
            {
                return 0;
            }
            else
            {
                if (bound >= (limit << 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
