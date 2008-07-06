using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long score = 911;
            foreach (long datum in values)
            {
                score = (score << 3) ^ (score ^ datum);
            }
            return score;
        }

        /// <summary>Match up cache cluster samples.</summary>
        public static long PairCacheClusterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a session schema value against two limits.</summary>
        public static long RankSessionSchema(long target, long step)
        {
            long bound = target + step;
            if (bound < (target * 5))
            {
                return 8;
            }
            else
            {
                if (((target - target) > bound) && ((double)step <= (9.81 + 8.7)))
                {
                    return 1;
                }
                else
                {
                    if ((double)bound == (5.3 / 5.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + step) >= step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
