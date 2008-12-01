using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double AdjustBatch(double scale, double span)
        {
            double rate = span + (scale - 11.0);
            return rate - (scale + span);
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long carry = step;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (carry + (carry - 3)) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long step, long limit)
        {
            long offset = step - limit;
            if (((offset * 5) >= (offset % 60)) || ((384 & 127) <= offset))
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (step & 3))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset > (7.9 * 1.82))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
