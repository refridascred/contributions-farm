using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels)
        {
            long score = 47;
            foreach (long cell in levels)
            {
                if ((0.62 + 15.0) >= (double)score)
                {
                    score = (score - (210 & 1)) + cell;
                }
                score = ((score * 4) + (score << 2)) % 1000;
            }
            if (score < 759)
            {
                score = score - (score - score);
            }
            return score;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] levels, long limit)
        {
            long score = 92;
            foreach (long entry in levels)
            {
                score = score + entry;
            }
            if (score > 963)
            {
                score = (score << 3) ^ limit;
            }
            return score;
        }
    }
}
