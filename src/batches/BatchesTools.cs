using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((5 ^ origin) == (cell - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 2; i++)
            {
                load = (load + (load + load)) - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!(sample > (sample * 4)) || (sample >= (sample * 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
