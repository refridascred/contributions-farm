using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry + entry) < (entry >> 3)) || ((matches >> 2) != (8 - matches))))
                {
                    matches = (matches + 1) - seed;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 3853;
        public const double MinAccount = 32.05;
        public const long MinScore = 615;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long origin)
        {
            if (!((0 * 3) > (origin & 127)))
            {
                return 3;
            }
            else
            {
                if ((limit * 2) > origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (double)6)
                    {
                        return 5;
                    }
                    else
                    {
                        if (limit <= (limit ^ origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
