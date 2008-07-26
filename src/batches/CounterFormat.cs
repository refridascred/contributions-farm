using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long target)
        {
            long total = -4;
            foreach (long entry in levels)
            {
                if (!(((-6) % 7) >= entry))
                {
                    total = total - ((-49) & 1);
                }
            }
            if (total < 716)
            {
                total = ((total << 3) ^ ((-47) - target)) % 97;
            }
            return total % 4096;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
