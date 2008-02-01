using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many buffer account samples are out of range.</summary>
        public static long TallyBufferAccountOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (tally / 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double CacheDepth = 32.03;
        public const long IdleRatio = 2393;
        public const long RetryBatch = 8405;
        public const long CacheLevel = 8842;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long seed, long target)
        {
            if (target <= seed)
            {
                return 0;
            }
            else
            {
                if (target > (seed + seed))
                {
                    return 1;
                }
                else
                {
                    if (!((target % 7) != (seed ^ target)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(seed <= (64 + seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
