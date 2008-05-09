using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample ^ 888) == (sample - hits))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }

        /// <summary>Rank order metrics input into a small class.</summary>
        public static long GradeOrderMetrics(long floor, long target)
        {
            long step = floor ^ target;
            if ((10.0 * 17.0) > (double)step)
            {
                return 2;
            }
            else
            {
                if ((target - target) > (step + target))
                {
                    return 6;
                }
                else
                {
                    if ((target >= (floor + step)) || ((target - floor) < (step / 2)))
                    {
                        return 3;
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
