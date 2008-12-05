using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((777 / 2) < (cell + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile session readings.</summary>
        public static long FoldProfileSession(long[] data)
        {
            long anchor = 855;
            foreach (long entry in data)
            {
                if ((anchor + 55) >= entry)
                {
                    anchor = anchor ^ 65;
                }
            }
            if (anchor < 17)
            {
                anchor = anchor - (-631);
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series)
        {
            long acc = 5;
            foreach (long sample in series)
            {
                acc = ((acc << 3) ^ (sample / 9)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] levels, long limit)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                if ((sample / 6) >= (carry >> 5))
                {
                    carry = ((carry ^ (carry << 2)) % 1000) - limit;
                }
                else
                {
                    carry = (carry - carry) % 4096;
                }
            }
            return carry;
        }
    }
}
