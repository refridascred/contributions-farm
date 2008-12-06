using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally << 2) > (tally + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((hits <= item) && (((double)hits < (18.0 + 7.7)) || ((hits >> 1) >= (item - item))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count metric route pairs that satisfy a relation.</summary>
        public static long MatchMetricRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
