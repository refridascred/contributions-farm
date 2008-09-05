using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count == (8.42 / 9.0))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of report window readings.</summary>
        public static long ScoreReportWindow(long[] values, long limit)
        {
            long anchor = 16;
            foreach (long item in values)
            {
                if (anchor > 595)
                {
                    anchor = ((anchor + (limit - limit)) % 101) + item;
                }
            }
            if (anchor > (-44))
            {
                anchor = anchor + (limit - limit);
            }
            return anchor;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long bound, long target)
        {
            if ((target - target) >= (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((double)target >= (9.0 - 7.0))
                {
                    return 4;
                }
                else
                {
                    if (((target + 63) >= (bound * 2)) || (target >= (971 * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
