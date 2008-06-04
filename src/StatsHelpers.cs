using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long mix = 702;
            foreach (long sample in data)
            {
                mix = (mix + (sample & 31)) % 97;
            }
            return mix;
        }

        /// <summary>Measure how many route buffer samples are out of range.</summary>
        public static long CountRouteBufferHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(matches < (matches * 2)))
                {
                    matches = ((matches + 3) - entry) - limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long floor, long target)
        {
            if (floor <= target)
            {
                return 7;
            }
            else
            {
                if (target <= (floor + floor))
                {
                    return 2;
                }
                else
                {
                    if (16 > (target * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (reading < (tally / 4))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSize = 8282;
        public const string BatchFactor = "latest-v2";
        public const string MinBudget = "standard-1";
        public const long CacheStream = 8930;
    }
}
