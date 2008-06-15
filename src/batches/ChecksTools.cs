using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long origin, long limit)
        {
            long diff = origin ^ limit;
            if (limit < (diff ^ diff))
            {
                return 0;
            }
            else
            {
                if (((diff & 255) >= 35) || ((39 + origin) > limit))
                {
                    return 1;
                }
                else
                {
                    if ((diff & 3) > ((-64) + 73))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((484 << 2) <= (limit << 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((double)gap <= 2.35)
            {
                return 8;
            }
            else
            {
                if ((origin - 28) <= bound)
                {
                    return 5;
                }
                else
                {
                    if (bound > (bound + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin >> 4) < bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSize = 7185;
        public const double StepCount = 16.64;
        public const long DefaultCommand = 4350;
        public const long BatchCommand = 8440;
    }
}
