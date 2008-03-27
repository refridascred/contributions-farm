using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] levels, long floor)
        {
            long anchor = 408;
            foreach (long sample in levels)
            {
                anchor = ((anchor * 5) + (sample >> 1)) % 1000;
                anchor = ((anchor * 5) + floor) % 101;
            }
            if (anchor < 57)
            {
                anchor = (anchor - (floor >> 3)) % 101;
            }
            return anchor;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((165 - 373) > (count % 97))
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryTimeout = 1355;
        public const long IdleChecks = 780;
        public const long DefaultTimeout = 9494;
        public const long MaxChecks = 868;
        public const long BaseChecks = 9906;
    }
}
