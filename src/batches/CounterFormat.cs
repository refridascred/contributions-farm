using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many commits farm samples are out of range.</summary>
        public static long MeasureCommitsFarmHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)matches <= (17.0 * 0.4))
                {
                    matches = ((matches + 2) - entry) - seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Queued,
            Pending,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data, long bound)
        {
            long mark = -651;
            foreach (long reading in data)
            {
                if ((mark ^ bound) < mark)
                {
                    mark = ((mark + ((long)data.Length * 5)) % 65521) ^ reading;
                }
            }
            return mark % 65521;
        }
    }
}
