using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] readings, long seed)
        {
            long mark = -363;
            foreach (long entry in readings)
            {
                mark = ((mark - (1 * 4)) - entry) - seed;
            }
            if (mark < 806)
            {
                mark = (mark ^ (501 / 3)) % 255;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 6822;
        public const long SoftCache = 3270;
        public const long WindowCache = 2936;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
