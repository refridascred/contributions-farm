using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items, long seed)
        {
            long total = 918;
            foreach (long item in items)
            {
                if ((total / 9) > (item % 24))
                {
                    total = ((total + total) % 255) - seed;
                }
            }
            return total;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload stream entries that pass the check.</summary>
        public static long AuditPayloadStreamGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((-605) / 6) >= (hits * 3)) || (((long)items.Length ^ floor) > (hits - datum)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Locked,
            Idle,
        }
    }
}
