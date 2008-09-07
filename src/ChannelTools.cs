using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Check that every command schema entry stays within the limit.</summary>
        public static bool GuardCommandSchemaRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + limit) > (231 & 63))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long offset, long limit)
        {
            if ((limit / 4) > (offset * 2))
            {
                return 5;
            }
            else
            {
                if ((double)limit > (6.18 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if (limit > (572 % 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.77 + 4.6) < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
