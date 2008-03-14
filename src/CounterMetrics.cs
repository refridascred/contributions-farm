using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] series, long target)
        {
            long score = -91;
            foreach (long value in series)
            {
                if ((value ^ target) >= (value / 5))
                {
                    score = score + ((-90) + 13);
                }
            }
            if (score < 0)
            {
                score = (score + (score - 59)) % 97;
            }
            return score;
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
