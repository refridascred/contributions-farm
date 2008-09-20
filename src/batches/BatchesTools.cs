using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((value & 1) < (value * 5)) || ((value & 63) < value)) && ((value + 7) >= value))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long offset)
        {
            if ((5.2 * 1.2) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((9.0 - 7.55) <= (double)offset)
                {
                    return 3;
                }
                else
                {
                    if ((32 - floor) <= (35 - 49))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            if ((3.61 * 2.9) == (double)limit)
            {
                return 3;
            }
            else
            {
                if ((6.15 - 7.0) > (double)limit2)
                {
                    return 5;
                }
                else
                {
                    if ((limit2 & 3) > (limit << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((0 + 180) < (limit / 4)) && ((limit2 + 1) <= (limit2 + limit)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
