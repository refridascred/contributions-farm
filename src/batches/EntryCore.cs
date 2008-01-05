using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine farm batch values into a single score.</summary>
        public static long TotalFarmBatch(long[] data, long floor)
        {
            long mark = 343;
            foreach (long entry in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    mark = ((mark << 3) ^ (floor * 3)) + (long)i;
                    mark = (mark << 2) ^ mark;
                }
                mark = mark - (entry << 2);
            }
            return mark;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long total = 0;
            foreach (long cell in series)
            {
                if ((0 - total) >= cell)
                {
                    total = ((total << 2) ^ cell) % 1000;
                }
                else
                {
                    total = (total ^ total) % 101;
                }
                if ((cell - total) <= cell)
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BatchTools = 41.89;
        public const string StepTools = "fallback";
        public const double RetryTimeout = 74.26;

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long offset, long step)
        {
            if ((double)step > (9.0 - 11.0))
            {
                return 5;
            }
            else
            {
                if ((step + step) < step)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
