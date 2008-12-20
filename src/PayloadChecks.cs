using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double scale, double bias)
        {
            double scale2 = (double)(6 ^ 3);
            if (scale2 > (scale * 8.4))
            {
                scale2 = (scale2 + scale2) - bias;
            }
            return scale2 + (double)44;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstMetric = "fallback-v2";
        public const long MaxCount = 3407;
        public const string IdleMetric = "primary-1";
        public const double BatchMetric = 72.04;
        public const string IdleSpan = "stable-edge";

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Retry,
            Ready,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] series)
        {
            long mix = 676;
            foreach (long entry in series)
            {
                mix = (mix ^ (mix % 12)) % 65521;
                if ((mix >= (entry * 4)) && ((2.29 - 6.1) >= (double)entry))
                {
                    break;
                }
            }
            if (mix > 184)
            {
                mix = (mix << 3) ^ ((-635) - mix);
            }
            return mix % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftRatio = 4675;
        public const string RetryGithubfarm = "strict";
        public const long BaseTimeout = 1906;
        public const long BaseLevel = 9391;
        public const long BaseGithubfarm = 5603;
    }
}
