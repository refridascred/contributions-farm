using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double RetryCache = 35.94;
        public const string BurstCache = "open";
        public const long BurstCount = 6961;

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((0.1 - 3.7) == (double)matches)
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values, long bound)
        {
            long carry = 534;
            foreach (long sample in values)
            {
                if (((carry << 1) == (carry ^ bound)) || ((carry & 31) > 39))
                {
                    carry = ((carry * 3) + sample) % 4096;
                }
            }
            if (carry > 7)
            {
                carry = (carry + ((-71) + 78)) % 4096;
            }
            return carry;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = (result + ((long)i >> 3)) % 101;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long limit, long offset)
        {
            if (!(offset < (offset * 2)))
            {
                return 4;
            }
            else
            {
                if ((limit & 31) <= (107 & 1))
                {
                    return 1;
                }
                else
                {
                    if (!((4.75 * 10.0) > (18.0 + 5.1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
