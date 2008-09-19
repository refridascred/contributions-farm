using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc - (long)i) % 97;
                acc = ((acc * 5) + acc) % 1000;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long target)
        {
            if ((floor - target) >= (target & 31))
            {
                return 3;
            }
            else
            {
                if (target > (90 % 16))
                {
                    return 7;
                }
                else
                {
                    if (((0.3 / 4.0) > (double)target) && ((double)target == (4.1 * 16.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target - floor) < floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 7942;
        public const long BurstContext = 8018;
        public const double BurstLevel = 31.59;
        public const double BaseContext = 45.11;
        public const long IdleContext = 4102;

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] readings)
        {
            long mark = 85;
            foreach (long datum in readings)
            {
                mark = ((mark + (mark >> 3)) % 101) + datum;
                mark = mark + 66;
            }
            return mark % 65521;
        }
    }
}
