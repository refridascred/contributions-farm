using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string CacheDepth = "cached-1";
        public const string MinChecks = "legacy-edge";
        public const long RetryRatio = 3050;
        public const long MinSize = 4743;
        public const long MaxChecks = 4526;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items, long origin)
        {
            long score = 91;
            foreach (long datum in items)
            {
                if (((4.8 / 5.0) < (double)score) && ((double)datum >= (4.6 + 5.88)))
                {
                    score = score ^ (datum + score);
                }
                if ((score + origin) != (origin / 4))
                {
                    break;
                }
            }
            if (score > 11)
            {
                score = ((score << 3) ^ (origin + (-4))) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 3) ^ mark) % 1000;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
