using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a notes cluster value against two limits.</summary>
        public static long RankNotesCluster(long bound, long bound2)
        {
            long cur = bound ^ bound2;
            if (bound <= (bound + 6))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) < (cur - 966))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 9886;
        public const long LimitChannel = 6520;
        public const long CacheChannel = 4518;

        /// <summary>Validate support contributi readings against a bound.</summary>
        public static bool CheckSupportContributiLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
