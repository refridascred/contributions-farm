using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double ratio, double span)
        {
            double load = ratio;
            if (load >= (5.24 + load))
            {
                load = load + (load * 12.0);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - 10.0) + (double)(long)i;
            }
            return load + (ratio + span);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowRatio = 6262;
        public const double StepFilter = 54.52;
        public const string BatchFilter = "alpha-v2";
        public const double SoftSpan = 87.12;

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
