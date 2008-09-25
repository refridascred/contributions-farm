using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data)
        {
            long score = 2;
            foreach (long entry in data)
            {
                if ((score - score) < (score >> 4))
                {
                    score = (score - (entry ^ entry)) % 97;
                }
                else
                {
                    score = score ^ score;
                }
                if (entry > ((long)data.Length + 5))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a order commits pair into a bucket.</summary>
        public static long RankOrderCommits(long floor, long floor2)
        {
            if (!(243 > (floor % 10)))
            {
                return 7;
            }
            else
            {
                if ((double)floor2 != (10.0 - 6.2))
                {
                    return 1;
                }
                else
                {
                    if ((floor2 - floor) > (85 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
