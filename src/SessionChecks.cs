using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public long Score { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Derive the next commits metric value from a seed.</summary>
        public static long IterateCommitsMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }
    }
}
