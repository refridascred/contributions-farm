using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long CountProfileOrderGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (limit <= (datum + limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Ratio { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item - 30) != (hits / 7))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples)
        {
            long sum = 22;
            foreach (long reading in samples)
            {
                sum = (sum + sum) % 97;
                if ((reading + reading) < (reading << 2))
                {
                    sum = sum ^ (reading / 4);
                }
            }
            return sum;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
