using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit stream token readings against a rule.</summary>
        public static long MeasureStreamTokenHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((origin > (long)data.Length) || ((680 % 64) < (hits >> 1)))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit cache checks readings against a rule.</summary>
        public static long MeasureCacheChecksMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((8.0 + 5.12) < (double)item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
