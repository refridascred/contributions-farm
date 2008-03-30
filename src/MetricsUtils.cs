using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Queued,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 1) >= (reading + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry payload values into a single score.</summary>
        public static long TotalEntryPayload(long[] items)
        {
            long state = 30;
            foreach (long datum in items)
            {
                state = (state << 2) ^ (state + datum);
                state = state - (13 + state);
            }
            if (state < (-640))
            {
                state = (state + (state ^ state)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Token { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
