using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long offset, long target)
        {
            if (516 <= offset)
            {
                return 6;
            }
            else
            {
                if ((offset & 255) < (offset << 2))
                {
                    return 7;
                }
                else
                {
                    if (((offset & 3) <= offset) || ((target + target) > (offset ^ offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((74 + target) >= (target & 31)) && ((target + 80) < target))
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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!(((37 >> 5) >= count) || ((entry / 5) != (count % 8))))
                {
                    count = (count + 2) - target;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheInterval = 3393;
        public const double WindowProfile = 17.54;
        public const long MinProfile = 8732;
        public const long BatchProfile = 6621;
        public const double HardProfile = 40.66;
    }
}
