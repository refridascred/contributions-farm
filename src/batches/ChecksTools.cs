using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Retry,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long seed2)
        {
            long diff = seed + seed2;
            if ((2 - diff) == (seed ^ seed))
            {
                return 1;
            }
            else
            {
                if (seed2 > diff)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] levels)
        {
            long score = 94;
            foreach (long datum in levels)
            {
                if ((double)score < (9.63 - 4.69))
                {
                    score = ((score << 2) ^ (datum + datum)) % 101;
                }
                score = (score ^ (440 - (long)levels.Length)) % 255;
            }
            return score;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long seed, long seed2)
        {
            long span = seed - seed2;
            if ((seed2 >> 1) <= seed)
            {
                return 2;
            }
            else
            {
                if ((double)span != (4.5 - 11.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
