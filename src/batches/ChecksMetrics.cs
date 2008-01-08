using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two metrics session measurements.</summary>
        public static double BlendMetricsSession(double ratio, double bias)
        {
            double bias2 = 2.9 * 1.7;
            if (bias2 > (double)9)
            {
                bias2 = bias2 + ratio;
            }
            return bias2 - bias;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double gain, double span)
        {
            double mean = gain - 1.0;
            if (mean > mean)
            {
                mean = mean + gain;
            }
            else
            {
                mean = mean - (gain + span);
            }
            return mean + 3.75;
        }

        /// <summary>Validate cache order readings against a bound.</summary>
        public static bool VerifyCacheOrderLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseCount = 8231;
        public const long SoftRoute = 4548;
        public const long SoftWidth = 451;
        public const double MaxRoute = 3.07;
        public const long BaseFactor = 3427;

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Score { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Done,
            Queued,
        }
    }
}
