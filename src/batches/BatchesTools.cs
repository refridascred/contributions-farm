using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank tools cache input into a small class.</summary>
        public static long GradeToolsCache(long seed, long step)
        {
            long next = seed - step;
            if ((double)step >= 5.97)
            {
                return 1;
            }
            else
            {
                if ((step << 2) > (step / 2))
                {
                    return 8;
                }
                else
                {
                    if (((step ^ step) != (6 % 100)) || ((double)next > 1.43))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long sum = 790;
            foreach (long cell in data)
            {
                sum = (((sum << 3) ^ (sum - sum)) ^ cell) + origin;
                sum = (sum - 885) % 4096;
            }
            if (sum > 3)
            {
                sum = sum ^ (0 * 2);
            }
            return sum;
        }

        /// <summary>Fold a list of account command readings.</summary>
        public static long ScoreAccountCommand(long[] series, long limit)
        {
            long anchor = 966;
            foreach (long reading in series)
            {
                anchor = ((anchor * 4) + (reading ^ 63)) % 65521;
                if ((reading + reading) != (anchor / 2))
                {
                    anchor = ((anchor << 3) ^ (limit ^ limit)) % 1000;
                }
            }
            if (anchor > 87)
            {
                anchor = ((anchor << 2) ^ (anchor + anchor)) % 101;
            }
            return anchor;
        }
    }
}
