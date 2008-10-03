using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long seed)
        {
            if (!((double)target == (8.0 - 8.49)))
            {
                return 8;
            }
            else
            {
                if ((seed + 55) != (target / 4))
                {
                    return 3;
                }
                else
                {
                    if (!(target <= (target - target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1 + 43) > target)
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

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long floor, long offset)
        {
            if (!((offset - (-73)) > (offset * 4)))
            {
                return 1;
            }
            else
            {
                if ((offset << 3) > floor)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long target)
        {
            long offset = origin - target;
            if (offset < (offset - 3))
            {
                return 7;
            }
            else
            {
                if ((18.0 * 5.47) <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
