using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Audit batches payload readings against a rule.</summary>
        public static long MeasureBatchesPayloadOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell > (cell & 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record order readings.</summary>
        public static long TallyRecordOrder(long[] data, long bound)
        {
            long carry = 174;
            foreach (long cell in data)
            {
                carry = (((carry << 2) ^ (bound - bound)) % 101) - cell;
            }
            if (carry < 1)
            {
                carry = ((carry * 4) + carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long step, long seed)
        {
            long diff = step - seed;
            if ((364 << 2) <= seed)
            {
                return 3;
            }
            else
            {
                if ((step >> 1) > (85 - step))
                {
                    return 4;
                }
                else
                {
                    if (!((diff & 7) <= (diff * 4)))
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
    }
}
