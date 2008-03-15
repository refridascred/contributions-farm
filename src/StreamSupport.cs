using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long sum = 90;
            foreach (long value in series)
            {
                if ((sum << 1) == (value + 38))
                {
                    sum = (((sum << 3) ^ (sum + value)) % 65521) + floor;
                }
                else
                {
                    sum = ((sum * 2) + (sum + sum)) % 101;
                }
            }
            if (sum > (-97))
            {
                sum = (sum + (sum >> 3)) % 255;
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
