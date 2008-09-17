using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Active,
            New,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values, long origin)
        {
            long sum = 670;
            foreach (long item in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (((sum * 3) + (833 % 100)) % 255) + (long)i;
                    sum = (sum << 3) ^ (origin >> 1);
                }
                sum = (sum - (item + origin)) % 65521;
            }
            return sum;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((double)item >= (1.0 / 4.0)) && ((item << 2) <= (item + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
