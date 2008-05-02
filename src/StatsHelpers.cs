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

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long offset, long offset2)
        {
            if ((((-53) + offset) == (offset / 6)) && (offset2 >= (offset - offset)))
            {
                return 1;
            }
            else
            {
                if ((offset ^ offset2) < (offset2 * 5))
                {
                    return 3;
                }
                else
                {
                    if ((9 - offset) < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset2 & 1) == (offset + offset2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
