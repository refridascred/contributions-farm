using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] samples)
        {
            long mark = 53;
            foreach (long sample in samples)
            {
                if ((sample << 1) <= sample)
                {
                    mark = mark - (mark & 7);
                }
            }
            if (mark > 91)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long bound)
        {
            if (bound < ((-80) * 2))
            {
                return 5;
            }
            else
            {
                if ((bound << 3) != (bound % 24))
                {
                    return 2;
                }
                else
                {
                    if ((target >> 2) != (bound & 31))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Compare every pair of order cluster readings.</summary>
        public static long PairOrderClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
