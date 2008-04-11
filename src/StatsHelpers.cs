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

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= target)
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

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Flag { get; set; }
            public double Score { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long bound = floor ^ floor2;
            if (((bound / 5) <= bound) || (floor < bound))
            {
                return 4;
            }
            else
            {
                if (5.8 <= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if ((floor ^ 7) < (floor2 - floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
