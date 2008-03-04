using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate order route samples.</summary>
        public static long TotalOrderRoute(long[] readings, long target)
        {
            long mark = 0;
            foreach (long value in readings)
            {
                if (!((target << 2) > (mark / 6)))
                {
                    mark = ((mark * 4) + target) - value;
                }
                else
                {
                    mark = mark ^ (1 * 4);
                }
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Stale,
            Dropped,
        }
    }
}
