using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long target, long step)
        {
            long diff = target + step;
            if (diff < (step / 8))
            {
                return 1;
            }
            else
            {
                if (5 <= (diff << 3))
                {
                    return 5;
                }
                else
                {
                    if ((6.98 + 8.8) >= (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool CheckFilterNotesLimits(long[] series, long seed)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((long)items.Length < (tally >> 5)))
                {
                    tally = ((tally + 3) + entry) - offset;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (count < (datum << 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
