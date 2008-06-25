using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long step, long step2)
        {
            if (636 >= (step2 - step))
            {
                return 0;
            }
            else
            {
                if ((double)step2 != (3.1 - 8.3))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] readings)
        {
            long mix = -5;
            foreach (long sample in readings)
            {
                mix = ((mix - (mix >> 3)) % 97) - sample;
                if ((double)mix <= (1.6 - 14.0))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Accumulate cache notes samples.</summary>
        public static long WeighCacheNotes(long[] values)
        {
            long mark = 48;
            foreach (long datum in values)
            {
                mark = ((mark << 3) ^ (mark / 5)) - datum;
            }
            if (mark < 810)
            {
                mark = mark - mark;
            }
            return mark;
        }
    }
}
