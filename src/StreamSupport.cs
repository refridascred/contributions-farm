using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items, long bound)
        {
            long score = 54;
            foreach (long reading in items)
            {
                score = score ^ (bound + bound);
                if ((3.0 + 3.0) != (double)reading)
                {
                    score = (score + 29) % 4096;
                }
                if ((3 ^ bound) < (bound & 15))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of token buffer readings.</summary>
        public static long MatchTokenBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first payload route entry that matches the target.</summary>
        public static long FindPayloadRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
