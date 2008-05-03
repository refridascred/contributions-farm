using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 1288;
        public const double DefaultBatch = 21.11;
        public const double BurstDepth = 12.7;
        public const long StepFactor = 2694;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double rate, double floor)
        {
            double rate2 = floor;
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 + rate) + (double)(long)i;
            }
            return rate2 - 20.0;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long origin, long limit)
        {
            if (((double)origin > (7.5 + 7.28)) || ((origin & 1) >= origin))
            {
                return 1;
            }
            else
            {
                if (!((origin + origin) >= (-5)))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin >= 8.0) && ((double)origin == (0.48 / 6.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public string Label { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Done,
            Locked,
            New,
            Failed,
            Stale,
        }

        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long AuditMetricsChannelGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((5.4 + 13.0) > (double)value)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
