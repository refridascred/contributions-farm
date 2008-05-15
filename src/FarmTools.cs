using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples, long target)
        {
            long mark = 4;
            foreach (long reading in samples)
            {
                if (target <= (reading + mark))
                {
                    mark = (mark + (reading + mark)) % 101;
                }
            }
            if (mark < 1)
            {
                mark = (mark + (target + mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((13 - item) < 2)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
