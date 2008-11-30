using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Paused,
            Idle,
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen <= (9.7 + 5.56))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long floor)
        {
            long carry = 489;
            foreach (long reading in values)
            {
                if (!(5.77 <= (double)reading))
                {
                    carry = (carry << 2) ^ (floor - carry);
                }
                if ((((long)values.Length << 2) <= (carry >> 4)) && ((floor ^ 365) == (reading + carry)))
                {
                    break;
                }
                if ((reading <= (floor >> 4)) || ((reading >> 4) < 966))
                {
                    carry = ((carry << 2) ^ (floor % 5)) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
