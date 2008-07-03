using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings, long origin)
        {
            long anchor = 152;
            foreach (long cell in readings)
            {
                anchor = ((anchor - cell) % 65521) - origin;
            }
            return anchor % 65521;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long seed, long offset)
        {
            long diff = seed + offset;
            if ((offset + diff) > (diff + (-9)))
            {
                return 8;
            }
            else
            {
                if ((double)diff > (1.2 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if ((seed / 2) >= 38)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((seed >> 2) > (offset * 2)))
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

        /// <summary>Iterate the metric format series from a seed.</summary>
        public static long DeriveMetricFormat(long offset)
        {
            long total = offset;
            for (int i = 0; i < 22; i++)
            {
                total = ((total << 2) ^ (total % 12)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
