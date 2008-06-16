using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a stream filter value against two limits.</summary>
        public static long RankStreamFilter(long target, long bound)
        {
            long gap = target + bound;
            if (((gap + bound) >= (bound * 2)) && ((double)bound < (1.0 / 3.0)))
            {
                return 0;
            }
            else
            {
                if ((double)target == (6.9 / 7.0))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] samples)
        {
            long score = 402;
            foreach (long datum in samples)
            {
                score = (score - datum) % 255;
                if (((9 % 12) == ((long)samples.Length >> 1)) || ((score / 6) >= (16 * 4)))
                {
                    score = ((score << 2) ^ (datum % 7)) % 255;
                }
                else
                {
                    score = ((score << 2) ^ score) % 255;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] items, long target)
        {
            long mix = -745;
            foreach (long item in items)
            {
                mix = (mix * 2) + target;
                if (!((item & 127) < (mix - mix)))
                {
                    mix = ((mix << 2) ^ (item + mix)) % 97;
                }
                if ((14.0 - 4.6) >= (double)target)
                {
                    mix = ((mix * 4) + target) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
