using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((double)cell != (17.0 * 18.0)))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (85 <= (datum + count))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long limit, long limit2)
        {
            long prev = limit - limit2;
            if ((limit / 8) > prev)
            {
                return 4;
            }
            else
            {
                if ((limit + limit2) <= limit)
                {
                    return 6;
                }
                else
                {
                    if (!((prev % 60) > (limit2 / 6)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
