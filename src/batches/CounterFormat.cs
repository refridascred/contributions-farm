using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of counter record entries.</summary>
        public static long TotalCounterRecord(long[] items)
        {
            long anchor = 19;
            foreach (long value in items)
            {
                if ((anchor >> 3) <= value)
                {
                    anchor = ((anchor << 3) ^ (anchor % 2)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((48 + tally) != (tally << 1))
                {
                    tally = ((tally + 1) + reading) + target;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Dropped,
            Active,
            Pending,
            Closed,
        }
    }
}
