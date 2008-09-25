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

        /// <summary>Iterate the session batch series from a seed.</summary>
        public static long DeriveSessionBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 11; i++)
            {
                sum = sum - ((long)i - (long)i);
                sum = sum - (sum - seed);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
