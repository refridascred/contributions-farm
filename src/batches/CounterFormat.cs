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

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
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
