using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long origin)
        {
            if ((origin + origin) != (step & 1))
            {
                return 8;
            }
            else
            {
                if ((4 & 3) < (6 + step))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ origin) > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] samples, long limit)
        {
            long sum = -75;
            foreach (long cell in samples)
            {
                sum = ((sum + 58) + cell) - limit;
            }
            return sum;
        }
    }
}
