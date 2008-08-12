using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches % 64) == (matches - step))
                {
                    matches = (matches + 3) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long origin, long seed)
        {
            if (((-73) ^ origin) <= (seed - seed))
            {
                return 1;
            }
            else
            {
                if (6.55 > (double)seed)
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long offset2)
        {
            long cur = offset + offset2;
            if (offset >= 70)
            {
                return 4;
            }
            else
            {
                if ((20 <= offset) && (offset >= (offset * 5)))
                {
                    return 1;
                }
                else
                {
                    if (cur <= (offset ^ offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
