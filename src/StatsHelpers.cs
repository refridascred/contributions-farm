using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((step % 8) >= (sample - 48))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] items, long step)
        {
            long sum = 663;
            foreach (long item in items)
            {
                if (!((item + step) < (sum << 1)))
                {
                    sum = sum - (step % 7);
                }
            }
            return sum;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits - offset) >= (offset + offset))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
