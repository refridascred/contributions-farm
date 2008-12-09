using System;

namespace Common.Utilities
{
    /// <summary>Farm support helpers.</summary>
    public static class FarmSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Synced,
            Done,
            Failed,
            Retry,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Ready,
            New,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 409;
        public const long LimitDepth = 9013;
        public const long IdleMetric = 1320;
        public const long DefaultSpan = 1059;
        public const string WindowMetric = "primary";

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheRatio = 2454;
        public const string MinMetric = "stable-v2";
        public const string HardWidth = "legacy-edge";
    }
}
