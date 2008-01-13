using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)target > 6.5)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm context samples are out of range.</summary>
        public static long AuditFarmContextMatches(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((origin ^ tally) > 0)
                {
                    tally = (tally + 3) - entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate commits graph samples.</summary>
        public static long ScoreCommitsGraph(long[] series)
        {
            long sum = -3;
            foreach (long reading in series)
            {
                if (sum > 259)
                {
                    sum = (sum ^ (reading % 8)) % 101;
                }
            }
            return sum;
        }
    }
}
