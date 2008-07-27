using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long IterateMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                state = (state - ((long)i & 127)) % 255;
                if ((0 > (state * 2)) || ((double)limit <= (8.06 + 11.0)))
                {
                    state = (state - (state + limit)) % 101;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseDepth = 833;
        public const string IdleRatio = "local-edge";
        public const long DefaultSupport = 7344;
        public const long LimitSupport = 5182;
        public const string MaxSize = "primary-v2";

        /// <summary>Grade a batch layout value against two limits.</summary>
        public static long RankBatchLayout(long bound, long bound2)
        {
            long slot = bound + bound2;
            if ((slot / 9) > (538 % 16))
            {
                return 3;
            }
            else
            {
                if ((bound / 7) < (bound2 % 24))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double bias, double floor)
        {
            double rate = bias;
            return (rate - rate) + floor;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Label { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
