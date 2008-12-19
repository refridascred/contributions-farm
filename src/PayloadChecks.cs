using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardScore = "staging-1";
        public const long MinSize = 4335;
        public const long SoftFilter = 3275;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 5; i++)
            {
                if ((floor - 26) >= (floor << 2))
                {
                    total = (total ^ (352 % 3)) % 101;
                    total = (total - (floor - (long)i)) % 101;
                    break;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Audit checks filter readings against a rule.</summary>
        public static long CountChecksFilterGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell <= (count - count)) || ((double)bound > 5.9))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long floor)
        {
            long delta = origin ^ floor;
            if ((2.2 - 15.0) < (double)floor)
            {
                return 5;
            }
            else
            {
                if ((delta - floor) >= (origin + delta))
                {
                    return 8;
                }
                else
                {
                    if ((floor << 1) < (floor - delta))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 24; i++)
            {
                anchor = (anchor + (floor - floor)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
