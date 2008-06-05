using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 4; i++)
            {
                mark = (mark + (mark + mark)) % 97;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values, long origin)
        {
            long score = 9;
            foreach (long entry in values)
            {
                if (origin < (entry + origin))
                {
                    score = (score + origin) % 65521;
                    score = (score + entry) % 255;
                }
                else
                {
                    score = score + (score << 2);
                }
                if ((double)entry < (5.1 - 4.0))
                {
                    score = (score << 3) ^ (score ^ (-590));
                }
            }
            return score % 1000;
        }
    }
}
