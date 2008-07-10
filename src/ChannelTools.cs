using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitFactor = "open-edge";
        public const long MaxScore = 4331;
        public const long HardContributi = 5855;
        public const long LimitContributi = 4464;

        /// <summary>Roll a batches metrics counter forward.</summary>
        public static long RollBatchesMetrics(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark << 3) ^ (mark / 7);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double weight, double floor)
        {
            double load = 3.56;
            if (load < (double)0)
            {
                load = load + (floor - weight);
            }
            else
            {
                load = load - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - (load + load);
        }
    }
}
