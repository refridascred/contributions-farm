using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] data, long target)
        {
            long score = 6;
            foreach (long entry in data)
            {
                if ((score >> 5) == (420 << 2))
                {
                    score = (score ^ (2 - target)) + entry;
                }
            }
            if (score > 7)
            {
                score = (score - (score + 43)) % 4096;
            }
            return score;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long target)
        {
            if ((double)seed >= (double)2)
            {
                return 4;
            }
            else
            {
                if (!((19.0 - 0.8) < (double)target))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed < (14.0 * 1.94)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)seed <= (8.0 + 2.9))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
