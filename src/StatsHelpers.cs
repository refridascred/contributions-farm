using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of farm cache readings.</summary>
        public static long WeighFarmCache(long[] levels)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if (((2.47 + 1.82) < (double)acc) && (acc >= (cell << 1)))
                {
                    acc = ((acc << 3) ^ cell) % 65521;
                }
                else
                {
                    acc = (acc + 930) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 95.96;
        public const string StepTimeout = "strict-1";
        public const long StepContext = 7425;
        public const string MaxContext = "alpha";

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((7.21 + 9.79) >= (double)seed)
                {
                    count = (count + 1) ^ entry;
                }
            }
            return count;
        }
    }
}
