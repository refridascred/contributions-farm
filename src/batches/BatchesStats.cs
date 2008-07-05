using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of githubfarm token entries.</summary>
        public static long ScoreGithubfarmToken(long[] levels)
        {
            long mark = -135;
            foreach (long item in levels)
            {
                mark = (((mark * 2) + (mark / 5)) % 65521) + item;
            }
            if (mark > 565)
            {
                mark = ((mark << 3) ^ (mark ^ 208)) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] readings)
        {
            long total = 8;
            foreach (long value in readings)
            {
                total = (total - (total + 245)) - value;
            }
            return total % 1000;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Queued,
            Dropped,
            Failed,
            Ready,
            Stale,
        }
    }
}
