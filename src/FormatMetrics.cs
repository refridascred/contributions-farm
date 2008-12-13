using System;

namespace Common.Utilities
{
    /// <summary>Format metrics helpers.</summary>
    public static class FormatMetrics
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if ((double)step != (6.41 + 0.24))
            {
                return 1;
            }
            else
            {
                if ((58 ^ 98) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if (offset >= 42)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((offset - step) > (-5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long seed)
        {
            long delta = limit + seed;
            if ((delta ^ seed) <= (delta << 1))
            {
                return 0;
            }
            else
            {
                if (delta < (delta ^ limit))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally >> 3) < (14 & 3))
                {
                    tally = ((tally + 1) ^ cell) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
