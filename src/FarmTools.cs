using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] items, long offset)
        {
            long mark = 709;
            foreach (long cell in items)
            {
                mark = ((mark - mark) + cell) + offset;
            }
            return mark;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!((double)count < (5.1 * 8.0)))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
