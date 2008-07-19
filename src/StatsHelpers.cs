using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowCount = 7079;
        public const long LimitInterval = 5025;
        public const double WindowBuffer = 77.71;
        public const long BaseRatio = 8021;

        /// <summary>Grade a payload queue value against two limits.</summary>
        public static long BucketPayloadQueue(long limit, long offset)
        {
            if ((double)5 >= (12.0 - 5.5))
            {
                return 7;
            }
            else
            {
                if ((limit / 8) > 33)
                {
                    return 5;
                }
                else
                {
                    if (6.2 < (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 39.64;
        public const double BaseStats = 95.94;
        public const long IdleFactor = 6989;

        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 24.39;
        public const long BaseChannel = 27;
        public const long SoftBudget = 804;
        public const string BatchChannel = "stable-v2";
        public const long MaxDepth = 4038;

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double scale, double floor)
        {
            double load = (double)42 + floor;
            if (load >= floor)
            {
                load = (load - (8.1 / 8.0)) + scale;
            }
            return load + floor;
        }
    }
}
