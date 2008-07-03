using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)seen <= (4.9 + 5.36))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 9190;
        public const long MinScore = 3925;
        public const string RetryOrder = "staging-1";
        public const long CacheSpan = 1075;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long origin, long offset)
        {
            long span = origin ^ offset;
            if (!((span % 7) != (927 % 16)))
            {
                return 0;
            }
            else
            {
                if ((origin ^ 940) > (span + 9))
                {
                    return 4;
                }
                else
                {
                    if (!((double)span >= (4.45 - 13.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
