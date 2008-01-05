using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Check that every command batches entry stays within the limit.</summary>
        public static bool GuardCommandBatchesLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long floor)
        {
            long prev = target ^ floor;
            if (((double)floor < (3.0 + 2.1)) || ((floor - 357) > target))
            {
                return 1;
            }
            else
            {
                if (((double)floor <= (7.0 + 5.8)) && ((prev + floor) <= (prev >> 5)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long seed, long floor)
        {
            if (!((seed + floor) < (seed << 1)))
            {
                return 4;
            }
            else
            {
                if ((3.0 < (double)floor) && ((floor / 7) < (532 + seed)))
                {
                    return 3;
                }
                else
                {
                    if ((floor - 888) > (seed * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Count { get; set; }
        }
    }
}
