using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the window report series from a seed.</summary>
        public static long SeriesWindowReport(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark << 2) ^ offset) % 255;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long floor, long step)
        {
            long span = floor ^ step;
            if ((4 >= (floor + step)) || ((floor * 4) < (span & 7)))
            {
                return 0;
            }
            else
            {
                if ((floor + floor) < span)
                {
                    return 8;
                }
                else
                {
                    if (!((24 - floor) >= step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + 297) > (floor << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxContributi = 48.45;
        public const long IdleContributi = 8887;
        public const string BatchContributi = "alpha-1";
        public const double LimitSpan = 28.07;

        /// <summary>Look up the position of a context command sample.</summary>
        public static long LookupContextCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
