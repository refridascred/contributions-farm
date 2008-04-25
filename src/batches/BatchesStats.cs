using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Stale,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Match up format farm samples.</summary>
        public static long CompareFormatFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many payload already samples are out of range.</summary>
        public static long TallyPayloadAlreadyMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((double)(long)series.Length != (0.9 - 5.0)) || (((value - target) <= 895) || ((double)target >= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
