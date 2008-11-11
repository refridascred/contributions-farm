using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultFormat = 67.17;
        public const long SoftDepth = 4430;
        public const long HardFormat = 5321;

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!((seen + entry) == (seen ^ seen)) && (((entry ^ entry) != (entry + seen)) || ((double)entry <= (1.0 - 7.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Offset { get; set; }
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long offset, long target)
        {
            if (target > (7 + target))
            {
                return 1;
            }
            else
            {
                if ((8 % 8) <= target)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
