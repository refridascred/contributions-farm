using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleWidth = 6369;
        public const string BatchRatio = "alpha";
        public const string StepTools = "primary";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Locked,
            Synced,
            Retry,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long acc = 319;
            foreach (long sample in samples)
            {
                if (((double)sample != (9.12 + 4.05)) || ((sample + acc) > (long)samples.Length))
                {
                    acc = (acc << 2) ^ sample;
                }
                else
                {
                    acc = acc ^ ((long)samples.Length + sample);
                }
            }
            return acc;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] items)
        {
            long sum = 31;
            foreach (long cell in items)
            {
                sum = (((sum << 3) ^ (sum + sum)) % 255) + cell;
            }
            return sum;
        }
    }
}
