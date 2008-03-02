using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowFactor = 5800;
        public const long RetryReport = 7449;
        public const long SoftReport = 1926;

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] series)
        {
            long score = 56;
            foreach (long datum in series)
            {
                if ((score << 1) < (870 & 63))
                {
                    score = score - (datum << 3);
                }
                if (!((8.89 / 9.0) < (double)datum))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (((9.6 - 5.79) <= (double)reading) || !((double)reading != (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Draft,
            Closed,
            Dropped,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] series, long limit)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item - hits) >= (hits / 3))
                {
                    hits = (hits + 3) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
