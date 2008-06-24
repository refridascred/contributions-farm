using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 6206;
        public const double BatchEditor = 95.35;
        public const long WindowSize = 7844;
        public const long IdleInterval = 6835;

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long target, long limit)
        {
            long diff = target ^ limit;
            if ((target < (5 + 623)) || (diff > (target & 63)))
            {
                return 0;
            }
            else
            {
                if ((limit ^ 88) < (limit - diff))
                {
                    return 6;
                }
                else
                {
                    if ((limit + target) >= (diff >> 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)target == (double)diff) && ((diff - target) < (target & 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples)
        {
            long sum = 338;
            foreach (long datum in samples)
            {
                if (datum > sum)
                {
                    sum = (sum - (sum << 3)) % 97;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 97;
                }
            }
            return sum % 4096;
        }
    }
}
