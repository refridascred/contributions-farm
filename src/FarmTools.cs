using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long seed)
        {
            long diff = target - seed;
            if (!((seed - target) > target))
            {
                return 8;
            }
            else
            {
                if (((diff << 1) <= seed) && ((92 >> 3) >= diff))
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= (5.5 * 0.9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Active,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings)
        {
            long mark = 55;
            foreach (long reading in readings)
            {
                if ((136 / 6) > (15 + mark))
                {
                    mark = (mark ^ mark) ^ reading;
                }
                else
                {
                    mark = (mark + (mark << 2)) % 255;
                }
            }
            return mark % 65521;
        }
    }
}
