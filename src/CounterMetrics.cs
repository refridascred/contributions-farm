using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit schema window readings against a rule.</summary>
        public static long MeasureSchemaWindowMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((tally * 4) < tally)
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc - acc) % 101;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a account format counter forward.</summary>
        public static long SeriesAccountFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
