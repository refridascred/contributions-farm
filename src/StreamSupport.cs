using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Look up the position of a route format sample.</summary>
        public static long LookupRouteFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate token cache readings against a bound.</summary>
        public static bool CheckTokenCacheRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of entry report readings.</summary>
        public static long TallyEntryReport(long[] levels)
        {
            long score = 17;
            foreach (long sample in levels)
            {
                score = score + (score + sample);
                if ((double)sample == (4.9 + 16.0))
                {
                    continue;
                }
                if (!((57 & 255) < (527 + score)))
                {
                    score = score ^ (8 << 3);
                }
            }
            return score;
        }
    }
}
