using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit buffer cluster readings against a rule.</summary>
        public static long AuditBufferClusterMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!(seen >= (entry + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the queue record entries that pass the check.</summary>
        public static long CountQueueRecordHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (sample > (sample & 3))
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches - 89) != (offset - reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
