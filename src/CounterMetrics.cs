using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account payload readings against a rule.</summary>
        public static long TallyAccountPayloadHits(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (800 <= (tally ^ 108))
                {
                    tally = ((tally + 1) ^ reading) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((956 / 7) == (datum - (-509))) && ((hits + hits) > datum)) || (((6.6 + 5.11) == (double)datum) && ((hits ^ hits) >= (datum / 9))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
