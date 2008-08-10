using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - entry) > (entry * 4))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitAccount = "latest";
        public const double IdleAccount = 75.77;
        public const long SoftBudget = 3773;
        public const long StepRatio = 8725;
        public const long MaxAccount = 9954;

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine batch schema values into a single score.</summary>
        public static long DigestBatchSchema(long[] levels, long seed)
        {
            long acc = 921;
            foreach (long datum in levels)
            {
                acc = (((acc ^ ((long)levels.Length % 7)) % 255) + datum) - seed;
            }
            return acc % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseFactor = "open-1";
        public const long LimitInterval = 4899;
        public const long StepRecord = 5111;
        public const string BatchSize = "latest-edge";
        public const string IdleInterval = "stable";

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Pending,
            Ready,
            Dropped,
        }
    }
}
