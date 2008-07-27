using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Stale,
            Dropped,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series)
        {
            long state = 8;
            foreach (long reading in series)
            {
                state = ((state << 2) ^ (reading - reading)) % 97;
                state = (state ^ (state >> 2)) % 101;
            }
            if (state < 669)
            {
                state = (state << 2) ^ (state + state);
            }
            return state;
        }
    }
}
