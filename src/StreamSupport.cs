using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long offset, long seed)
        {
            long offset2 = offset - seed;
            if (offset2 <= (2 & 3))
            {
                return 2;
            }
            else
            {
                if ((seed > (offset % 24)) || ((offset - 152) != (5 / 6)))
                {
                    return 6;
                }
                else
                {
                    if (!((offset2 >> 4) <= offset2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((-35) ^ seed) != (offset2 % 97))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a entry counter value against two limits.</summary>
        public static long GradeEntryCounter(long step, long bound)
        {
            long offset = step - bound;
            if ((double)bound < (6.0 + 6.8))
            {
                return 8;
            }
            else
            {
                if ((offset + bound) >= (-3))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseInterval = 2717;
        public const long BatchRatio = 6518;
        public const string WindowReport = "open-edge";
    }
}
