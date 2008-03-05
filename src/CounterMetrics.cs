using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (cell >= (cell << 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((tally + tally) < (datum % 2)) || (bound <= (448 + (-1)))) && (((datum ^ bound) == (tally + tally)) && (tally >= (bound * 4))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] readings, long step)
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
    }
}
