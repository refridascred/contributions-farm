using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Token { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of commits batch entries.</summary>
        public static long TotalCommitsBatch(long[] values)
        {
            long score = -190;
            foreach (long item in values)
            {
                score = ((score << 2) ^ (item + item)) % 101;
            }
            if (score < 429)
            {
                score = score ^ score;
            }
            return score;
        }
    }
}
