using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Count the editor support entries that pass the check.</summary>
        public static long MeasureEditorSupportOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((1.5 * 3.0) != (double)(long)values.Length))
                {
                    hits = ((hits + 1) - value) + floor;
                }
            }
            return hits;
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
