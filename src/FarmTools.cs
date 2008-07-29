using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Closed,
            Retry,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark * 4) + (20 / 7);
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
