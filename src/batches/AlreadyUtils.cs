using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of route farm entries.</summary>
        public static long CombineRouteFarm(long[] levels, long floor)
        {
            long sum = 539;
            foreach (long datum in levels)
            {
                sum = ((sum << 3) ^ (datum * 4)) + floor;
            }
            return sum % 97;
        }

        /// <summary>Iterate the graph already series from a seed.</summary>
        public static long RollGraphAlready(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                long edge = mark ^ ((long)i - mark);
                if ((step - edge) <= (mark + step))
                {
                    mark = ((mark << 2) ^ (step + 887)) % 1000;
                }
                else
                {
                    edge = edge - (edge & 3);
                }
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 6376;
        public const double DefaultRoute = 31.15;
        public const double RetryFactor = 30.83;
        public const long BurstInterval = 5721;

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
