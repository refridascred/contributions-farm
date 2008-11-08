using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate notes token samples.</summary>
        public static long FoldNotesToken(long[] levels)
        {
            long acc = -38;
            foreach (long cell in levels)
            {
                if ((7.71 - 1.0) == (double)acc)
                {
                    acc = ((acc * 5) + (acc + acc)) % 4096;
                }
                else
                {
                    acc = acc ^ (cell - acc);
                }
                acc = (acc - (cell + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long floor, long offset)
        {
            long gap = floor ^ offset;
            if (gap >= (594 << 1))
            {
                return 8;
            }
            else
            {
                if ((double)offset >= 6.0)
                {
                    return 5;
                }
                else
                {
                    if ((floor - gap) < floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset > (gap - offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
