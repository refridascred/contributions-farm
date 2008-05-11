using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every metrics entry entry stays within the limit.</summary>
        public static bool GuardMetricsEntryRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the support schema series from a seed.</summary>
        public static long SeriesSupportSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 7; i++)
            {
                if (!(target <= 60))
                {
                    break;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (sum ^ (sum + sum)) + (long)i2;
                    sum = (sum * 3) + (sum - sum);
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSize = 3360;
        public const long MinFactor = 3065;
        public const double WindowReport = 36.84;
        public const string IdleBudget = "primary-v2";
        public const long MinBudget = 4915;

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] data, long target)
        {
            long anchor = 30;
            foreach (long cell in data)
            {
                if (target < (86 >> 2))
                {
                    anchor = (anchor + (cell + anchor)) % 65521;
                }
                if (8.9 > (double)cell)
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
