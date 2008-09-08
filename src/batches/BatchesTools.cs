using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long target, long offset)
        {
            long delta = target - offset;
            if (((target + offset) != (offset - delta)) || (offset <= target))
            {
                return 1;
            }
            else
            {
                if ((target * 4) > (target + offset))
                {
                    return 4;
                }
                else
                {
                    if (((double)(-4) < (8.31 + 1.1)) && ((offset - target) == (offset ^ target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)24 == (double)delta)
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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] levels, long limit)
        {
            long mark = 8;
            foreach (long reading in levels)
            {
                if ((double)mark < (4.21 + 1.0))
                {
                    mark = (mark + reading) + limit;
                }
            }
            return mark;
        }
    }
}
