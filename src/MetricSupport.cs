using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many route context samples are out of range.</summary>
        public static long AuditRouteContextMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (limit >= (hits + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] levels, long origin)
        {
            long score = 981;
            foreach (long cell in levels)
            {
                score = (((score * 2) + (origin >> 3)) % 101) - cell;
            }
            if (score < 69)
            {
                score = ((score * 2) + score) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Stale,
            Idle,
            Done,
        }
    }
}
