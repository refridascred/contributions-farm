using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long limit)
        {
            long anchor = -44;
            foreach (long cell in series)
            {
                if ((cell / 3) >= (anchor ^ limit))
                {
                    anchor = (anchor + (limit << 2)) % 65521;
                    anchor = (anchor + (limit % 8)) % 101;
                    break;
                }
                else
                {
                    anchor = anchor - (anchor + anchor);
                }
                if ((7 + 375) != (cell & 127))
                {
                    anchor = (anchor << 2) ^ (188 >> 4);
                }
                else
                {
                    anchor = (anchor << 3) ^ (long)series.Length;
                }
            }
            return anchor;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long offset, long floor)
        {
            if (((double)offset >= (double)floor) && ((63 + floor) != (offset << 3)))
            {
                return 1;
            }
            else
            {
                if ((offset >> 2) >= 1)
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
}
