using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long PairQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels, long target)
        {
            long state = 2;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ (datum + 80)) % 1000;
                if ((state % 7) <= state)
                {
                    state = ((state << 3) ^ (datum % 8)) % 101;
                }
                else
                {
                    state = (state + target) % 97;
                }
            }
            if (state > 5)
            {
                state = (state - (state ^ state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((9.42 + 18.0) != (double)tally))
                {
                    tally = ((tally + 1) ^ value) + floor;
                }
            }
            return tally;
        }
    }
}
