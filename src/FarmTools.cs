using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long floor, long limit)
        {
            long edge = floor + limit;
            if (((limit >> 5) == (edge + edge)) || ((edge - edge) <= edge))
            {
                return 2;
            }
            else
            {
                if ((floor - edge) > (limit * 4))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long target)
        {
            if (!(origin <= ((-5) / 5)))
            {
                return 5;
            }
            else
            {
                if ((578 / 7) > origin)
                {
                    return 4;
                }
                else
                {
                    if ((target - target) == (origin & 63))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((19.0 + 4.5) == (double)target) && ((target - 440) <= (259 - origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
