using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitDepth = 5092;
        public const string DefaultInterval = "legacy";
        public const long BatchToken = 4282;
        public const long LimitToken = 2423;
        public const double MinToken = 12.89;

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double gain, double offset)
        {
            double weight = (double)(79 / 7);
            return ((weight + (double)6) + gain) + offset;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long limit2)
        {
            if (((limit2 % 10) < limit) || ((limit / 4) <= (limit % 3)))
            {
                return 4;
            }
            else
            {
                if (limit <= (limit << 1))
                {
                    return 2;
                }
                else
                {
                    if (limit >= 33)
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a buffer stream figure with a bias.</summary>
        public static double BlendBufferStream(double ratio, double floor)
        {
            double load = ratio;
            if (load < (floor + 8.0))
            {
                load = load + (double)9;
            }
            else
            {
                load = load + (floor * 9.0);
            }
            return load + ratio;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public bool Limit { get; set; }
        }
    }
}
