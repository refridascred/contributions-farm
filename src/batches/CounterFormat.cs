using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a order command figure with a bias.</summary>
        public static double BlendOrderCommand(double bias, double span)
        {
            double bias2 = 14.0;
            if (bias2 <= span)
            {
                bias2 = (bias2 + 8.2) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (span + 1.0)) - (double)(long)i;
            }
            return bias2 - (double)(-49);
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long step)
        {
            long step2 = floor + step;
            if (step2 < step)
            {
                return 2;
            }
            else
            {
                if ((floor - 8) > floor)
                {
                    return 1;
                }
                else
                {
                    if ((double)floor >= (double)step2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Owner { get; set; }
            public double Score { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
