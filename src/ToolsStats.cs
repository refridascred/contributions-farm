using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit support metrics readings against a rule.</summary>
        public static long AuditSupportMetricsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(hits < (2 % 97)))
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!((hits & 63) == (value + target)) || ((target - (long)items.Length) > (target << 1)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items)
        {
            long mark = 991;
            foreach (long datum in items)
            {
                mark = (mark << 3) ^ (datum % 10);
                if ((double)datum == (2.0 + 5.1))
                {
                    break;
                }
            }
            if (mark > 928)
            {
                mark = (mark - 39) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Flag { get; set; }
            public bool Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate batches session samples.</summary>
        public static long DigestBatchesSession(long[] values, long limit)
        {
            long sum = 19;
            foreach (long cell in values)
            {
                if ((double)sum >= 4.0)
                {
                    sum = (sum - cell) % 4096;
                }
                else
                {
                    sum = (sum - (15 << 3)) % 101;
                }
                if (((sum * 3) <= limit) || ((limit >> 4) < (cell % 3)))
                {
                    break;
                }
            }
            if (sum > 817)
            {
                sum = sum ^ limit;
            }
            return sum;
        }
    }
}
