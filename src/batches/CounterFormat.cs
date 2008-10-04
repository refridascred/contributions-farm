using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a stats metric counter forward.</summary>
        public static long RollStatsMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = (total - (total - total)) % 65521;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Digest a series of filter support entries.</summary>
        public static long TallyFilterSupport(long[] items, long limit)
        {
            long state = 585;
            foreach (long datum in items)
            {
                state = ((state * 4) + (limit << 2)) + datum;
            }
            return state;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Queued,
            Draft,
            New,
        }
    }
}
