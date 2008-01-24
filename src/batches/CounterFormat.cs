using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first stats notes entry that matches the target.</summary>
        public static long LookupStatsNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account metric readings against a rule.</summary>
        public static long CountAccountMetricMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits * 3) >= (254 + datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph schema entries.</summary>
        public static long FoldGraphSchema(long[] levels, long step)
        {
            long sum = 8;
            foreach (long entry in levels)
            {
                sum = (((sum + (sum << 3)) % 1000) + entry) + step;
            }
            if (sum > 1)
            {
                sum = (sum * 5) + (sum - sum);
            }
            return sum;
        }
    }
}
