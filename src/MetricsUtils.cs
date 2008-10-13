using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Label { get; set; }
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Pending,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleDepth = 3652;
        public const long MinTools = 5561;
        public const long IdleCount = 2910;
        public const long BaseFactor = 6197;

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long anchor = 782;
            foreach (long value in samples)
            {
                anchor = anchor ^ anchor;
                if ((value + anchor) > (long)samples.Length)
                {
                    anchor = (anchor - (value >> 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long mix = target;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    mix = (mix ^ (mix - 90)) ^ (long)i2;
                }
                mix = (mix + (72 + mix)) % 1000;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
