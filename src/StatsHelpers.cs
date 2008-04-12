using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LookupLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowWidth = 9585;
        public const long DefaultSpan = 4735;
        public const string LimitLevel = "open-1";
        public const double BaseDepth = 70.35;

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long target, long seed)
        {
            if ((seed + target) >= (6 % 12))
            {
                return 5;
            }
            else
            {
                if ((target & 127) == (target ^ target))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
