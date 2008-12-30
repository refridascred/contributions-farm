using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 5; i++)
            {
                mark = mark + mark;
                if ((mark >= (mark - mark)) || ((mark % 12) >= (floor >> 5)))
                {
                    mark = (mark << 3) ^ (mark << 2);
                    mark = ((mark * 2) + (floor * 4)) % 255;
                }
                else
                {
                    mark = mark + mark;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a account counter counter forward.</summary>
        public static long SeriesAccountCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
