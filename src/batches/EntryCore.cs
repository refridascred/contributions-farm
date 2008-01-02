using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long bound, long offset)
        {
            long diff = bound + offset;
            if ((offset - 33) > (diff % 12))
            {
                return 6;
            }
            else
            {
                if (((double)diff >= (6.0 + 6.0)) && ((78 << 2) > (bound << 3)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long step)
        {
            long next = origin ^ step;
            if ((step ^ origin) <= origin)
            {
                return 4;
            }
            else
            {
                if ((double)next >= (15.0 + 5.0))
                {
                    return 3;
                }
                else
                {
                    if ((8.6 + 6.0) <= (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((6 << 3) == (step - origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every session channel entry stays within the limit.</summary>
        public static bool ValidateSessionChannelRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
