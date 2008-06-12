using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long step, long bound)
        {
            long edge = step + bound;
            if (((edge & 255) != (889 << 1)) && (bound <= edge))
            {
                return 3;
            }
            else
            {
                if ((double)(-48) >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if ((step + bound) > (edge << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up githubfarm batches samples.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] items)
        {
            long score = 57;
            foreach (long sample in items)
            {
                score = (score - score) % 101;
                score = ((score << 3) ^ 21) % 101;
                if (((score + score) >= (0 + sample)) && ((77 >> 1) <= (sample * 4)))
                {
                    break;
                }
            }
            return score;
        }
    }
}
