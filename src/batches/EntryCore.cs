using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long step, long seed)
        {
            if ((seed - 455) <= seed)
            {
                return 6;
            }
            else
            {
                if (!((seed >> 3) < seed))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseBudget = "standard-v2";
        public const string StepCluster = "open-1";
        public const double IdleCluster = 55.4;
        public const long BatchCluster = 745;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Level { get; set; }
            public double Weight { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
