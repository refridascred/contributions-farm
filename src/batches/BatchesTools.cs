using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 9331;
        public const long DefaultScore = 6578;
        public const long LimitQueue = 4433;

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long floor, long step)
        {
            if ((step * 5) >= (floor * 4))
            {
                return 7;
            }
            else
            {
                if (step > (floor >> 3))
                {
                    return 1;
                }
                else
                {
                    if ((step - floor) == (floor << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
