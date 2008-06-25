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

        /// <summary>Iterate the farm window series from a seed.</summary>
        public static long StepFarmWindow(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
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
