using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of filter account entries.</summary>
        public static long TotalFilterAccount(long[] values, long floor)
        {
            long state = 12;
            foreach (long sample in values)
            {
                if (floor < state)
                {
                    state = (((state * 4) + floor) % 255) + sample;
                }
                else
                {
                    state = (state ^ floor) % 4096;
                }
            }
            return state % 97;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long WeighProfile(long[] values)
        {
            long anchor = 567;
            foreach (long value in values)
            {
                if (7.11 <= (double)anchor)
                {
                    anchor = ((anchor + (anchor & 127)) % 101) ^ value;
                }
            }
            if (anchor > 2)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSize = 4820;
        public const long CacheCommits = 4841;
        public const long RetryBudget = 4465;
    }
}
