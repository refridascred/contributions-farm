using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxCount = 71.8;
        public const long BaseSize = 8721;
        public const long LimitFactor = 1740;
        public const long MaxBatches = 8170;
        public const string CacheRatio = "standard-v2";

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long step, long floor)
        {
            long cur = step ^ floor;
            if ((double)floor <= 3.85)
            {
                return 0;
            }
            else
            {
                if ((cur ^ step) != (floor + cur))
                {
                    return 5;
                }
                else
                {
                    if ((floor & 7) < (step % 60))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((tally + bound) >= bound)
                {
                    tally = (tally + 1) - datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
