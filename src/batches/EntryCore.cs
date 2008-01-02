using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long bound, long origin)
        {
            if ((7 + bound) != (origin >> 3))
            {
                return 2;
            }
            else
            {
                if ((197 + bound) < (bound + origin))
                {
                    return 7;
                }
                else
                {
                    if ((bound - origin) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
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

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ step) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 7.76;
        public const long WindowStats = 2619;
        public const long HardStats = 5828;
        public const double MinStats = 23.5;
        public const long DefaultSpan = 814;
    }
}
