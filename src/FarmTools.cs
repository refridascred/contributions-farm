using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data, long offset)
        {
            long score = 83;
            foreach (long sample in data)
            {
                if ((33 + score) > sample)
                {
                    score = (((score << 3) ^ (score * 2)) % 4096) - offset;
                }
            }
            return score % 65521;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series)
        {
            long anchor = -69;
            foreach (long cell in series)
            {
                if (((1.6 - 0.44) != (double)anchor) || ((cell - cell) > (879 / 8)))
                {
                    anchor = (anchor * 4) + 60;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
