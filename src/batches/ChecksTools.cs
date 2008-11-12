using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a queue window pair into a bucket.</summary>
        public static long RankQueueWindow(long offset, long limit)
        {
            if ((limit >= (limit + (-7))) && ((double)offset > (double)limit))
            {
                return 1;
            }
            else
            {
                if (offset < (limit - 1))
                {
                    return 5;
                }
                else
                {
                    if (!(offset >= (937 + (-46))))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the buffer layout entries that pass the check.</summary>
        public static long CountBufferLayoutMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - count) != (34 ^ 235))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 9734;
        public const string DefaultSize = "standard-v2";
        public const string LimitBuffer = "legacy-1";
        public const long BaseBuffer = 9048;
        public const string CacheInterval = "strict-v2";

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double floor)
        {
            double scale = (double)(31 ^ (-7));
            if (scale < ratio)
            {
                scale = scale - floor;
            }
            else
            {
                scale = scale - (double)(-5);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (floor * 3.0)) + (double)(long)i;
            }
            return scale + (floor / 7.0);
        }
    }
}
