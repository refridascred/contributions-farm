using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a editor support value against two limits.</summary>
        public static long RankEditorSupport(long origin, long limit)
        {
            if ((origin + origin) <= origin)
            {
                return 1;
            }
            else
            {
                if ((6 - limit) <= (origin ^ limit))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((item + hits) < target) && ((item < (item + item)) || (hits <= (hits * 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Pending,
            Dropped,
            Active,
        }

        /// <summary>Audit farm order readings against a rule.</summary>
        public static long AuditFarmOrderGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((item > 65) && (7 <= (target * 4))) && (((6.7 / 4.0) > (double)item) || ((seen - 69) <= (item & 15))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
