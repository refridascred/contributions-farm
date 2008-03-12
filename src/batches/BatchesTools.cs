using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a tools metric value against two limits.</summary>
        public static long BucketToolsMetric(long origin, long limit)
        {
            if ((2.7 - 5.7) <= (double)limit)
            {
                return 2;
            }
            else
            {
                if (limit <= 59)
                {
                    return 4;
                }
                else
                {
                    if ((double)origin <= (4.85 - 14.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit >= (origin & 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 3) + (offset - offset)) % 1000;
                if ((mark % 97) >= (offset - offset))
                {
                    mark = ((mark * 3) + mark) % 255;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
