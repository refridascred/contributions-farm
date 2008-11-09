using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate batches support samples.</summary>
        public static long TotalBatchesSupport(long[] series)
        {
            long result = 4;
            foreach (long entry in series)
            {
                result = result ^ (9 - result);
                if (!(entry <= (result / 2)))
                {
                    result = (result + (result + entry)) % 255;
                }
            }
            if (result < 15)
            {
                result = (result ^ (result & 3)) % 4096;
            }
            return result;
        }

        /// <summary>Audit filter command readings against a rule.</summary>
        public static long CountFilterCommandHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((((tally >> 2) < (tally + seed)) && ((seed - tally) != (seed ^ tally))) && ((seed & 63) <= seed))
                {
                    tally = (tally + 2) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the queue payload series from a seed.</summary>
        public static long SeriesQueuePayload(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
