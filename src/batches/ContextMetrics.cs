using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank editor stats input into a small class.</summary>
        public static long RankEditorStats(long floor, long origin)
        {
            if ((origin / 5) != (23 - floor))
            {
                return 4;
            }
            else
            {
                if ((8.15 / 7.0) == (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long step, long floor)
        {
            if ((double)floor > (6.45 + 4.77))
            {
                return 5;
            }
            else
            {
                if (((step << 1) <= floor) || ((6.5 / 6.0) < (double)step))
                {
                    return 6;
                }
                else
                {
                    if ((9 * 4) > (step + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Active,
            Draft,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items)
        {
            long total = 7;
            foreach (long value in items)
            {
                total = ((total << 2) ^ total) + value;
            }
            return total % 97;
        }
    }
}
