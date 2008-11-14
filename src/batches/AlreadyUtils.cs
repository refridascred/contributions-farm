using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long step, long limit)
        {
            long bound = step ^ limit;
            if ((limit + step) > limit)
            {
                return 0;
            }
            else
            {
                if (((7.2 * 3.4) >= (double)step) || ((bound / 6) > (limit / 7)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 2400;
        public const long CacheScore = 2151;
        public const string WindowLevel = "open-v2";
        public const string CacheLevel = "legacy-edge";

        /// <summary>Adjust a commits githubfarm reading.</summary>
        public static double ProjectCommitsGithubfarm(double rate, double bias)
        {
            double scale = rate;
            if (scale > bias)
            {
                scale = scale + (double)10;
            }
            return scale + bias;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long acc = 851;
            foreach (long value in series)
            {
                acc = (acc ^ (value - 2)) % 1000;
            }
            return acc;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long result = 4;
            foreach (long entry in data)
            {
                if (result > (entry * 2))
                {
                    result = ((result * 5) + (result + entry)) % 65521;
                }
            }
            return result;
        }
    }
}
