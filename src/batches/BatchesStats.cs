using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every metric stats entry stays within the limit.</summary>
        public static bool VerifyMetricStatsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a payload schema pair into a bucket.</summary>
        public static long BucketPayloadSchema(long offset, long target)
        {
            long offset2 = offset + target;
            if ((7.51 / 7.0) != (double)offset2)
            {
                return 4;
            }
            else
            {
                if (((double)offset2 <= (4.14 / 7.0)) || ((target ^ 468) <= (target - target)))
                {
                    return 0;
                }
                else
                {
                    if ((offset2 * 3) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry << 2) ^ (carry + carry);
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
