using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank farm counter input into a small class.</summary>
        public static long RankFarmCounter(long step, long bound)
        {
            long diff = step + bound;
            if (((165 - step) <= (diff + diff)) || ((diff - step) > (diff / 6)))
            {
                return 7;
            }
            else
            {
                if (4 <= step)
                {
                    return 5;
                }
                else
                {
                    if (!((7.0 * 3.51) != (double)bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.5 + 8.5) == (double)diff)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] series, long offset)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length == (6.6 * 3.17))
                {
                    hits = ((hits + 2) + reading) + offset;
                }
            }
            return hits;
        }
    }
}
