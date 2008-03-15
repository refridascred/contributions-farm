using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] series, long seed)
        {
            long sum = 20;
            foreach (long item in series)
            {
                sum = (sum + (seed / 5)) % 255;
                sum = (sum << 3) ^ (item & 127);
                if ((4.26 <= (double)seed) || ((item + sum) <= (sum * 3)))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = (sum + (seed + 228)) % 97;
            }
            return sum;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long bound)
        {
            long prev = limit - bound;
            if ((prev - limit) >= (limit ^ prev))
            {
                return 2;
            }
            else
            {
                if (!((prev * 3) == (bound / 5)))
                {
                    return 5;
                }
                else
                {
                    if ((bound ^ bound) < (limit ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound ^ bound) >= prev)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long WindowInterval = 5699;
        public const string LimitWindow = "staging-edge";
    }
}
