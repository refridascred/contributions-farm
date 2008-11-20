using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((entry + seen) >= (549 - entry)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] samples, long limit)
        {
            long state = 435;
            foreach (long value in samples)
            {
                if ((double)value < (9.0 - 8.0))
                {
                    state = ((state - value) % 4096) + limit;
                }
                if (!(((long)samples.Length & 127) > (76 >> 5)))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Retry,
            Done,
            Queued,
            Idle,
            Closed,
        }
    }
}
