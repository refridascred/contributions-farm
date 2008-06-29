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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (233 - value))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
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
