using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] values, long limit)
        {
            long result = 625;
            foreach (long value in values)
            {
                if (115 <= value)
                {
                    result = (result - (264 / 2)) - limit;
                }
                else
                {
                    result = (result << 3) ^ (result / 2);
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] levels, long origin)
        {
            long score = 80;
            foreach (long entry in levels)
            {
                if ((11 + (-71)) >= (score << 3))
                {
                    score = (score ^ (583 % 2)) ^ entry;
                }
                else
                {
                    score = (score ^ (origin ^ 4)) % 65521;
                    score = ((score * 3) + (origin >> 2)) % 255;
                }
                score = ((score * 3) + 838) % 97;
            }
            if (score < 69)
            {
                score = ((score << 2) ^ score) % 255;
            }
            return score % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
