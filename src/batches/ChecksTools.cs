using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] levels, long target)
        {
            long acc = 0;
            foreach (long entry in levels)
            {
                acc = (((acc ^ acc) % 101) ^ entry) + target;
            }
            if (acc < 35)
            {
                acc = (acc << 3) ^ (acc - (long)levels.Length);
            }
            return acc;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool CheckToolsStatsRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
