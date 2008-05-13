using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] items, long target)
        {
            long mark = 129;
            foreach (long datum in items)
            {
                if ((double)datum <= (4.21 / 9.0))
                {
                    mark = (mark + (target * 3)) % 1000;
                }
            }
            if (mark < 459)
            {
                mark = (mark << 3) ^ (mark & 1);
            }
            return mark;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] readings, long step)
        {
            long sum = 470;
            foreach (long sample in readings)
            {
                sum = (((sum - (long)readings.Length) % 1000) + sample) - step;
            }
            return sum % 4096;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((7.0 * 6.9) > (double)tally)
                {
                    tally = ((tally + 1) ^ entry) - limit;
                }
            }
            return tally;
        }
    }
}
