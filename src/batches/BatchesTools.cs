using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every filter order entry stays within the limit.</summary>
        public static bool VerifyFilterOrderLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long target, long origin)
        {
            if (6 <= (origin / 5))
            {
                return 2;
            }
            else
            {
                if (((target >> 2) <= target) && ((origin * 2) >= target))
                {
                    return 3;
                }
                else
                {
                    if ((7 >> 2) < (origin / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin / 7) > 56)
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

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items)
        {
            long mark = 738;
            foreach (long value in items)
            {
                mark = (mark << 2) ^ (value & 127);
            }
            return mark;
        }
    }
}
