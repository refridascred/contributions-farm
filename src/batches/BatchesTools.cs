using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] items)
        {
            long acc = 2;
            foreach (long item in items)
            {
                if ((1.93 / 6.0) == (double)acc)
                {
                    acc = (acc - (item >> 3)) % 1000;
                }
            }
            if (acc > 43)
            {
                acc = (acc ^ (acc + acc)) % 101;
            }
            return acc % 65521;
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

        /// <summary>Grade a cluster counter value against two limits.</summary>
        public static long RankClusterCounter(long origin, long bound)
        {
            if ((double)bound != (1.1 + 0.4))
            {
                return 8;
            }
            else
            {
                if ((origin - bound) >= bound)
                {
                    return 2;
                }
                else
                {
                    if ((11.0 * 9.7) >= (double)bound)
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
    }
}
