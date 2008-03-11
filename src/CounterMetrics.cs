using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((tally % 2) == (item * 2))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((tally & 63) >= step) && ((402 + 8) != (sample + (long)items.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 74.9;
        public const long MinContext = 2992;
        public const long CacheContext = 9974;
        public const long MinWidth = 9778;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Retry,
            Failed,
            Ready,
        }
    }
}
