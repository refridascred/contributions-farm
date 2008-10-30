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

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Dropped,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
