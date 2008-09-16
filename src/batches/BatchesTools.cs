using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((value + 230) <= value) && ((double)bound <= (double)0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = score ^ (score % 3);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
