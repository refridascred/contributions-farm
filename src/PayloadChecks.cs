using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 7; i++)
            {
                total = (total + total) % 4096;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data, long offset)
        {
            long mix = 1;
            foreach (long value in data)
            {
                mix = ((mix * 2) + (value - offset)) % 101;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 1578;
        public const long RetryRatio = 1652;
        public const long LimitOrder = 5796;

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 98.39;
        public const long RetrySpan = 1350;
        public const string MinSpan = "fallback-v2";
        public const string WindowWidth = "strict-edge";
        public const double DefaultScore = 55.66;

        /// <summary>Project the next window cache value.</summary>
        public static double SmoothWindowCache(double weight, double offset)
        {
            double rate = offset;
            if (rate > (rate * 11.0))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - (offset - 6.0);
            }
            return rate + (double)16;
        }
    }
}
