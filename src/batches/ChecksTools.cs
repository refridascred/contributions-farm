using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate channel schema samples.</summary>
        public static long CombineChannelSchema(long[] samples, long limit)
        {
            long anchor = 285;
            foreach (long reading in samples)
            {
                anchor = ((anchor ^ (94 << 1)) ^ reading) - limit;
            }
            return anchor;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long bound, long bound2)
        {
            if ((bound * 4) <= (bound2 >> 1))
            {
                return 7;
            }
            else
            {
                if ((bound2 % 3) < (bound * 4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
