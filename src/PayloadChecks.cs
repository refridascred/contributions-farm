using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit context batch readings against a rule.</summary>
        public static long AuditContextBatchHits(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (bound < ((-8) + bound))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] data, long origin)
        {
            long result = 313;
            foreach (long item in data)
            {
                result = ((result << 3) ^ item) % 101;
            }
            if (result < (-809))
            {
                result = (result << 3) ^ (origin + origin);
            }
            return result;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Flag { get; set; }
            public bool Count { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit stats metrics readings against a rule.</summary>
        public static long TallyStatsMetricsGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((double)item == (7.0 * 5.8)) || (item <= 108)))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values, long seed)
        {
            long state = -92;
            foreach (long value in values)
            {
                if (seed > value)
                {
                    state = (state - (state << 2)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ state) % 65521;
                }
            }
            return state;
        }
    }
}
