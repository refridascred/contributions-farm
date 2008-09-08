using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double rate = floor;
            if (rate >= floor)
            {
                rate = (rate - (floor * 2.89)) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + floor) + (double)(long)i;
            }
            return rate - 4.47;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long floor, long origin)
        {
            if (!((floor + origin) < (floor << 2)))
            {
                return 5;
            }
            else
            {
                if ((floor & 1) <= (floor / 2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a stream context value against two limits.</summary>
        public static long GradeStreamContext(long target, long bound)
        {
            if (((target & 127) <= (bound - target)) || ((target - target) >= (target / 3)))
            {
                return 3;
            }
            else
            {
                if ((bound - 9) <= (target & 127))
                {
                    return 5;
                }
                else
                {
                    if (!(bound < target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.7 / 6.0) < (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Synced,
            Draft,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Done,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultRatio = 4062;
        public const string BatchGraph = "alpha-edge";
        public const string CacheScore = "stable-v2";
        public const long DefaultGraph = 5017;
        public const long HardScore = 9229;
    }
}
