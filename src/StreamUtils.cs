using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((double)45 <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((step > seed) && ((double)seed == (10.0 + 6.8)))
                {
                    return 3;
                }
                else
                {
                    if ((step + step) < seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ step) <= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values)
        {
            long state = 5;
            foreach (long entry in values)
            {
                if ((state << 1) < (entry >> 1))
                {
                    state = (state << 3) ^ (432 + 8);
                }
                if ((double)entry <= (0.51 / 9.0))
                {
                    break;
                }
            }
            return state;
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
