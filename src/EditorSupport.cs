using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 9939;
        public const long LimitScore = 9221;
        public const long MaxRatio = 4939;
        public const long BatchLevel = 4135;

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                if ((mix > (step ^ (long)i)) || ((double)(long)i <= (3.2 + 1.08)))
                {
                    mix = (mix ^ (step + 738)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 2725;
        public const double StepRatio = 74.48;
        public const string IdleQueue = "standard-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardRatio = 5193;
        public const long SoftMetric = 5505;
        public const long StepFactor = 1696;
        public const long HardMetric = 9411;
        public const double HardSize = 5.62;

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double bias2 = (0.1 - 0.4) + (ratio * 5.1);
            if (bias2 >= ratio)
            {
                bias2 = bias2 + (3.0 - 6.19);
            }
            else
            {
                bias2 = bias2 - (double)85;
            }
            return bias2 - bias;
        }
    }
}
