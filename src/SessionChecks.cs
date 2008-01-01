using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Active,
            Dropped,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum < (datum << 1))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long origin2)
        {
            if (!(origin <= (5 / 6)))
            {
                return 3;
            }
            else
            {
                if ((4.0 - 7.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
