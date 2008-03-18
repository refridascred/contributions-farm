using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Failed,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long offset)
        {
            long lane = target - offset;
            if ((4 >> 2) <= (target / 5))
            {
                return 7;
            }
            else
            {
                if (lane <= (97 << 2))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the contributi checks series from a seed.</summary>
        public static long DeriveContributiChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
