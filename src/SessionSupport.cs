using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheCount = 31.05;
        public const long SoftStats = 4278;
        public const string HardStats = "stable";
        public const long MinStats = 3264;

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long bound)
        {
            long result = 663;
            foreach (long reading in samples)
            {
                if (bound < result)
                {
                    result = result ^ 614;
                }
                else
                {
                    result = ((result << 2) ^ bound) % 255;
                }
                if ((3.3 < (double)bound) && ((bound - reading) >= (result / 9)))
                {
                    break;
                }
            }
            if (result > 121)
            {
                result = (result ^ (result - bound)) % 97;
            }
            return result;
        }
    }
}
