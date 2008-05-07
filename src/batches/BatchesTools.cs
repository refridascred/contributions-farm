using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] readings, long limit)
        {
            long score = -599;
            foreach (long entry in readings)
            {
                if (((0 % 12) < score) || ((limit - entry) > (score - score)))
                {
                    score = score + limit;
                }
                else
                {
                    score = (score + entry) % 101;
                }
                score = (score + (limit + (-665))) % 4096;
            }
            if (score > 1)
            {
                score = ((score * 3) + limit) % 101;
            }
            return score % 4096;
        }

        /// <summary>Digest a series of token account entries.</summary>
        public static long ScoreTokenAccount(long[] samples, long floor)
        {
            long anchor = 7;
            foreach (long cell in samples)
            {
                if ((cell ^ floor) >= (anchor / 3))
                {
                    anchor = (anchor + (floor >> 5)) % 1000;
                }
            }
            if (anchor < 111)
            {
                anchor = (anchor - (floor - floor)) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Done,
            Locked,
        }
    }
}
