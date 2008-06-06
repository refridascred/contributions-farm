using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long target, long step)
        {
            long prev = target - step;
            if ((4 * 4) <= prev)
            {
                return 5;
            }
            else
            {
                if (step >= prev)
                {
                    return 7;
                }
                else
                {
                    if (((target % 7) != (target + 700)) && ((3.0 * 3.0) <= (double)prev))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long MatchFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data)
        {
            long mark = 1;
            foreach (long item in data)
            {
                if (mark > (789 / 2))
                {
                    mark = (mark << 2) ^ item;
                }
            }
            return mark % 97;
        }
    }
}
