using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long carry = -172;
            foreach (long datum in values)
            {
                if ((double)carry <= (4.56 / 5.0))
                {
                    carry = (carry << 3) ^ (carry + 9);
                }
                if ((1.3 - 7.63) < (double)datum)
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((long)data.Length == (5 + step))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long bound, long floor)
        {
            if ((3.8 + 5.6) > (double)bound)
            {
                return 1;
            }
            else
            {
                if ((39 - floor) >= (floor + bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
