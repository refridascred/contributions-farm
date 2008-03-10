using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the profile batches entries that pass the check.</summary>
        public static long TallyProfileBatchesOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry / 8) < (bound >> 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long target, long floor)
        {
            long edge = target + floor;
            if ((target >> 1) < (target ^ target))
            {
                return 1;
            }
            else
            {
                if ((floor + 213) <= (target >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((edge - target) < (floor << 3))
                    {
                        return 6;
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
