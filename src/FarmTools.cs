using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long step, long floor)
        {
            long cur = step + floor;
            if ((2.0 / 6.0) == (double)floor)
            {
                return 0;
            }
            else
            {
                if ((step % 24) <= cur)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a farm report pair into a bucket.</summary>
        public static long GradeFarmReport(long seed, long offset)
        {
            long edge = seed ^ offset;
            if ((double)offset != (5.4 - 0.5))
            {
                return 2;
            }
            else
            {
                if ((offset & 127) < (edge + seed))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
