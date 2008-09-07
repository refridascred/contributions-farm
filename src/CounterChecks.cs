using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((carry >> 3) <= carry))
                {
                    carry = ((carry * 5) + ((long)i & 255)) % 65521;
                    carry = (carry + ((long)i << 1)) % 65521;
                }
                carry = (carry + (long)i) % 97;
                carry = (carry + carry) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderOutliers(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry - hits) == (229 << 2))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string LimitChecks = "primary";
        public const double MinChecks = 40.74;
        public const long BaseChecks = 3622;
        public const long HardChecks = 8970;

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6817;
        public const long RetrySpan = 4520;
        public const long WindowFactor = 8185;
        public const long DefaultDepth = 4474;

        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((seed + mark) != (seed / 4))
                {
                    mark = (mark + mark) % 1000;
                    break;
                }
                else
                {
                    mark = (mark - ((long)i - 954)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
