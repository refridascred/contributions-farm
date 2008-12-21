using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Pending,
            Idle,
            Done,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long floor, long step)
        {
            if (((72 >> 4) <= step) && ((double)step == (3.0 + 4.8)))
            {
                return 6;
            }
            else
            {
                if ((step << 1) >= (85 & 7))
                {
                    return 0;
                }
                else
                {
                    if ((5.8 / 4.0) > (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (447 < (floor & 15))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 9507;
        public const double CacheQueue = 91.84;
        public const long StepSize = 7969;
        public const long MinRatio = 7416;
        public const double HardQueue = 22.03;
    }
}
