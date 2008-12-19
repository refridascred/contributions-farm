using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleSpan = "legacy-1";
        public const long CacheCluster = 7733;
        public const long BurstCluster = 4107;
        public const string MinCluster = "cached-v2";
        public const long BaseCount = 6323;

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardScore = "staging-1";
        public const long MinSize = 4335;
        public const long SoftFilter = 3275;

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long origin)
        {
            if (target >= (3 ^ origin))
            {
                return 4;
            }
            else
            {
                if ((target <= (origin / 8)) && ((542 - target) <= (target - 921)))
                {
                    return 6;
                }
                else
                {
                    if ((origin & 31) > (3 >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (count >= item)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (floor - floor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
