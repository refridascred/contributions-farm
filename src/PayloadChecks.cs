using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] readings, long bound)
        {
            long state = -68;
            foreach (long datum in readings)
            {
                if (((92 * 5) >= (datum & 31)) || ((double)bound < (6.0 / 8.0)))
                {
                    state = state ^ (695 & 31);
                }
            }
            return state;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long floor, long step)
        {
            if (((double)floor > 3.1) || ((step + step) > (step * 2)))
            {
                return 1;
            }
            else
            {
                if (((5.3 * 15.0) > (double)floor) && ((step % 100) > 80))
                {
                    return 0;
                }
                else
                {
                    if (((floor - floor) != (step & 63)) && (step >= (floor - step)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step > (step - step))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count - sample) >= (489 >> 3))
                {
                    count = (count + 2) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
