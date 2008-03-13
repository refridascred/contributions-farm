using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long IdleLevel = 946;
        public const long LimitFormat = 9353;
        public const long WindowFormat = 4437;
        public const long CacheSpan = 5113;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value > (value + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Digest a series of record report entries.</summary>
        public static long TallyRecordReport(long[] data, long floor)
        {
            long carry = 590;
            foreach (long item in data)
            {
                carry = ((carry - (carry * 3)) - item) - floor;
            }
            return carry;
        }
    }
}
