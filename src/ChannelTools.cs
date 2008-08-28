using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long seed, long floor)
        {
            long cur = seed ^ floor;
            if (((floor % 3) <= (floor ^ seed)) && ((seed - 3) <= cur))
            {
                return 0;
            }
            else
            {
                if (floor > (459 - 6))
                {
                    return 6;
                }
                else
                {
                    if ((91 ^ seed) >= floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] series, long origin)
        {
            long score = 263;
            foreach (long cell in series)
            {
                if ((score / 4) > (894 << 1))
                {
                    continue;
                }
                else
                {
                    score = (score + score) % 255;
                    score = (score << 2) ^ (cell * 3);
                }
                if (((double)origin > (13.0 + 1.48)) && ((origin + 910) != (origin * 2)))
                {
                    score = (score * 2) + (814 & 31);
                }
            }
            return score;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 8685;
        public const long LimitRatio = 5116;
        public const double MinCommits = 23.58;
        public const long CacheDepth = 7646;
        public const double BatchSpan = 58.8;
    }
}
