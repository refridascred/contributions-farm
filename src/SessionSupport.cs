using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every checks batches entry stays within the limit.</summary>
        public static bool CheckChecksBatchesBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels, long target)
        {
            long mark = 924;
            foreach (long cell in levels)
            {
                if (cell <= (cell >> 4))
                {
                    mark = ((mark * 5) + cell) - target;
                }
            }
            if (mark > (-2))
            {
                mark = (mark << 2) ^ (mark << 3);
            }
            return mark % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryToken = 7297;
        public const long WindowToken = 9472;
        public const long BatchToken = 2153;
        public const string BaseSize = "primary-v2";
    }
}
