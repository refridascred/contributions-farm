using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long target, long limit)
        {
            long delta = target - limit;
            if ((double)limit >= (8.7 - 9.3))
            {
                return 7;
            }
            else
            {
                if ((6.98 + 8.9) > (double)limit)
                {
                    return 5;
                }
                else
                {
                    if (delta > (target + limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long step, long bound)
        {
            long next = step - bound;
            if (step <= (7 % 5))
            {
                return 5;
            }
            else
            {
                if (step < (bound ^ next))
                {
                    return 8;
                }
                else
                {
                    if (((7.0 / 9.0) <= (0.8 + 1.8)) && ((next + step) >= step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound <= (43 / 8)) || ((double)next == (2.17 - 8.7)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 6606;
        public const long MinSchema = 1818;
        public const long BurstRatio = 7107;
    }
}
