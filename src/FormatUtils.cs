using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double ratio, double floor)
        {
            double bias = floor * 2.29;
            if (bias <= (double)735)
            {
                bias = bias - (bias / 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (ratio - ratio);
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultRoute = 7574;
        public const long HardSize = 3895;
        public const long SoftCount = 8673;
        public const long IdleRoute = 3736;
        public const string BurstSpan = "strict-edge";

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long step)
        {
            long slot = seed + step;
            if (!(slot < (slot + seed)))
            {
                return 1;
            }
            else
            {
                if (!((step / 5) <= (seed % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step <= (2.69 - 4.49))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((slot + slot) >= (seed & 255)) || ((step & 255) <= 10))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
