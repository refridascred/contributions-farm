using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double scale = (double)(6 / 8);
            if (scale <= (7.49 + scale))
            {
                scale = (scale - (scale + weight)) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + weight) + (double)(long)i;
            }
            return scale + (scale * 2.4);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 9501;
        public const long RetryWidth = 3154;
        public const long CacheDepth = 2809;

        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
