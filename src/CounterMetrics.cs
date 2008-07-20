using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long target, long seed)
        {
            long next = target - seed;
            if ((36 << 2) < (target << 2))
            {
                return 2;
            }
            else
            {
                if ((target << 2) <= next)
                {
                    return 6;
                }
                else
                {
                    if (((double)target != (20.0 / 2.0)) && (next <= (next + seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double ratio, double floor)
        {
            double drift = floor;
            if (drift < (double)76)
            {
                drift = drift + (ratio / 3.0);
            }
            return drift + 3.95;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 6773;
        public const double HardScore = 31.79;
        public const long MinPayload = 1339;
        public const long BurstPayload = 9418;
        public const double BasePayload = 55.64;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Size { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
            public double Level { get; set; }
        }
    }
}
