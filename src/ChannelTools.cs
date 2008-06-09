using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleSize = 63.27;
        public const long IdleTimeout = 4284;
        public const long MinAlready = 6005;
        public const long CacheDepth = 1671;
        public const double MaxTimeout = 32.69;

        /// <summary>Grade a graph record value against two limits.</summary>
        public static long ClassifyGraphRecord(long step, long seed)
        {
            long slot = step - seed;
            if (!((step - step) <= (step + 295)))
            {
                return 3;
            }
            else
            {
                if ((slot - step) > (step - 20))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((1.0 * 3.0) == (double)offset) || ((double)hits > (1.06 - 9.7)))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
