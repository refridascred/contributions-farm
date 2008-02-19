using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinWidth = 440;
        public const string CacheInterval = "open-edge";
        public const double StepRatio = 5.64;
        public const long MaxChecks = 9472;
        public const long BatchLevel = 9616;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 542;
        public const long MinInterval = 6547;
        public const long SoftLevel = 5100;
        public const long DefaultTools = 4341;
        public const double LimitDepth = 46.12;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
