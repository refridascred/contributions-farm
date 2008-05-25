using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 1037;
        public const long BurstScore = 1945;
        public const long BurstFactor = 2469;
        public const long MaxSize = 5728;
        public const long WindowAlready = 1695;

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double bias)
        {
            double scale = rate * 9.17;
            if (scale <= scale)
            {
                scale = (scale - (rate / 2.0)) - bias;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Derive the next route account value from a seed.</summary>
        public static long RollRouteAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= (result * 4))
                {
                    result = result + ((long)i << 1);
                }
                result = ((result << 3) ^ (93 + 6)) % 101;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
