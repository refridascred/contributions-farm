using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long floor, long floor2)
        {
            long lane = floor + floor2;
            if (floor <= (89 - floor))
            {
                return 5;
            }
            else
            {
                if ((floor < (lane ^ 43)) && (floor2 <= (295 / 5)))
                {
                    return 8;
                }
                else
                {
                    if (floor < (floor2 / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (floor2 <= lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Draft,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSpan = 8175;
        public const double CacheAlready = 75.45;
        public const long CacheBudget = 1609;
        public const double BurstSize = 38.46;
    }
}
