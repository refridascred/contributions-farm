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

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
