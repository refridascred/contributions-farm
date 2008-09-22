using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank stats format input into a small class.</summary>
        public static long BucketStatsFormat(long origin, long floor)
        {
            if ((floor % 64) < floor)
            {
                return 8;
            }
            else
            {
                if (!(floor < (19 + floor)))
                {
                    return 6;
                }
                else
                {
                    if (origin > 55)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor + origin) < (floor - floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits & 31) >= (hits % 12)) && (((bound - hits) < datum) && ((8.91 - 4.0) >= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((state - state) >= (floor >> 4))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Offset { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
