using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long bound, long bound2)
        {
            if ((-62) >= bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 % 97) > (bound % 8))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool VerifyChannelLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
