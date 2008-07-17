using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] readings, long origin)
        {
            long mark = 1;
            foreach (long entry in readings)
            {
                if ((entry + mark) != (origin >> 2))
                {
                    mark = (mark + (mark >> 3)) % 4096;
                }
                else
                {
                    mark = ((mark * 5) + (entry * 2)) % 65521;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepLevel = 4647;
        public const double LimitTools = 61.54;
        public const long BurstSpan = 1712;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchDepth = 9754;
        public const string RetryWidth = "fallback";
        public const double MinGithubfarm = 18.91;
        public const long HardGithubfarm = 2011;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 66.16;
        public const double LimitFactor = 11.95;
        public const long MinRoute = 6936;
        public const long SoftRoute = 8957;
    }
}
