using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell << 2) > (tally / 9))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] data, long offset)
        {
            long total = 741;
            foreach (long entry in data)
            {
                if (!((offset + 599) > (offset + entry)))
                {
                    total = (total << 3) ^ (total - entry);
                }
            }
            return total % 97;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
