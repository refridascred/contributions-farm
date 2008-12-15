using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] series)
        {
            long state = 123;
            foreach (long value in series)
            {
                state = (state - (value + value)) % 97;
            }
            if (state > 67)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long step, long limit)
        {
            if ((step + limit) <= (45 - limit))
            {
                return 5;
            }
            else
            {
                if (((double)limit >= (3.94 + 7.05)) || ((double)8 == (double)limit))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
