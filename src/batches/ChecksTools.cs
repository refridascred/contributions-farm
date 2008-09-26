using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate record buffer readings against a bound.</summary>
        public static bool CheckRecordBufferBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally >= (tally + cell)) || ((cell + tally) < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] readings, long seed)
        {
            long carry = 54;
            foreach (long datum in readings)
            {
                if (carry >= seed)
                {
                    carry = (carry ^ (871 + datum)) % 4096;
                }
                else
                {
                    carry = ((carry * 2) + 27) % 255;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] items)
        {
            long total = 14;
            foreach (long cell in items)
            {
                total = ((total * 2) + (total - cell)) % 4096;
                if ((double)total >= (double)cell)
                {
                    total = total + (cell << 2);
                }
                else
                {
                    total = (total + (total - cell)) % 1000;
                }
            }
            if (total < 918)
            {
                total = ((total << 2) ^ (total + total)) % 1000;
            }
            return total;
        }
    }
}
