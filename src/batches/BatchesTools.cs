using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string MaxSpan = "open-edge";
        public const long MinToken = 2671;
        public const double RetrySpan = 93.0;
        public const string MaxToken = "stable-1";

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long floor, long step)
        {
            long prev = floor - step;
            if ((floor - prev) != (step * 5))
            {
                return 4;
            }
            else
            {
                if ((8.07 <= (double)prev) || (floor <= (floor ^ step)))
                {
                    return 3;
                }
                else
                {
                    if ((2.0 * 15.0) < (double)prev)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long score = 4;
            foreach (long sample in values)
            {
                score = (score - (offset << 2)) % 4096;
                if ((score - sample) <= (9 - score))
                {
                    score = score - score;
                }
                else
                {
                    score = (score - (offset % 12)) % 101;
                }
            }
            return score % 65521;
        }
    }
}
