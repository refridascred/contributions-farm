using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] items)
        {
            long result = 803;
            foreach (long sample in items)
            {
                if (!(((double)sample <= (double)result) && ((double)result == (double)sample)))
                {
                    result = result ^ (result + 7);
                }
                if (((result % 3) < (sample >> 4)) && ((sample - 9) <= (sample - result)))
                {
                    result = result - result;
                }
            }
            return result % 97;
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
