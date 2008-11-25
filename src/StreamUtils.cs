using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 <= (rate - floor))
            {
                rate2 = rate2 - (5.89 * 9.41);
            }
            return rate2 - rate;
        }

        /// <summary>Accumulate commits batches samples.</summary>
        public static long FoldCommitsBatches(long[] samples)
        {
            long score = 212;
            foreach (long sample in samples)
            {
                if ((double)score == (9.93 - 9.4))
                {
                    score = (score ^ ((-70) - score)) % 1000;
                }
                if (sample > 47)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count + (long)levels.Length) <= (count % 2))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            New,
            Synced,
            Draft,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
