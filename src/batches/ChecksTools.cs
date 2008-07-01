using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 4204;
        public const long RetryBuffer = 3789;
        public const double BatchDepth = 18.58;

        /// <summary>Project the next stats metric value.</summary>
        public static double AdjustStatsMetric(double scale, double floor)
        {
            double ratio = scale * 3.29;
            if (ratio < (double)98)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (double)1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public double Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Ready,
            Draft,
            Active,
            Done,
        }
    }
}
