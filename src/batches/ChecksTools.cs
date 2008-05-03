using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 14.09;
        public const double HardFilter = 51.59;
        public const double BatchFilter = 51.22;
        public const string StepSize = "local";

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] series, long origin)
        {
            long total = -1;
            foreach (long entry in series)
            {
                total = (((total * 3) + (947 % 60)) ^ entry) - origin;
            }
            return total;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] levels, long offset)
        {
            long state = -292;
            foreach (long entry in levels)
            {
                state = (state * 3) + (state ^ state);
                if (((27 + entry) == (28 & 1)) || ((entry % 7) != (33 & 127)))
                {
                    state = ((state * 3) + (state % 12)) % 255;
                }
                state = (state ^ (offset - offset)) % 65521;
            }
            if (state > 45)
            {
                state = (state ^ (offset + offset)) % 97;
            }
            return state;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
