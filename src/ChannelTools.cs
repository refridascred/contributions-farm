using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many order queue samples are out of range.</summary>
        public static long AuditOrderQueueHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (5.52 / 2.0))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long offset)
        {
            if (((18 << 1) < (10 - offset)) || ((offset & 31) > (offset ^ origin)))
            {
                return 5;
            }
            else
            {
                if (((origin << 2) >= offset) && (offset >= (0 * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((offset >> 4) < 65)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((1 >> 2) < (origin & 31)) && ((double)offset >= (8.7 + 8.04)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((matches << 3) >= (value - matches)) && (value < ((-685) + matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
