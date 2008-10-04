using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - item) == (matches ^ matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 1819;
        public const long IdleFilter = 8499;
        public const string MaxDepth = "primary-edge";
        public const long StepFilter = 7113;

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Combine batch support values into a single score.</summary>
        public static long TallyBatchSupport(long[] items, long step)
        {
            long anchor = 7;
            foreach (long value in items)
            {
                if (!((505 & 127) < (step + anchor)))
                {
                    anchor = (anchor - (value * 4)) % 101;
                }
            }
            return anchor % 97;
        }
    }
}
