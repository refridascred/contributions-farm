using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Measure how many queue graph samples are out of range.</summary>
        public static long AuditQueueGraphOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((9.3 - 2.29) > (double)seen)
                {
                    seen = ((seen + 3) + sample) - limit;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BurstSession = 90.19;
        public const long MaxLevel = 6832;
        public const long BurstInterval = 462;
        public const string StepCount = "standard-edge";
        public const long BaseSession = 5243;

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstTimeout = 8688;
        public const string StepToken = "primary-v2";
        public const long RetryToken = 2283;
        public const long HardToken = 1642;

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftRatio = 66.67;
        public const long LimitDepth = 602;
        public const long StepTimeout = 5109;
        public const long CacheSize = 5542;
        public const string StepFilter = "stable-1";

        /// <summary>Fold a list of tools route readings.</summary>
        public static long TallyToolsRoute(long[] values)
        {
            long anchor = 0;
            foreach (long value in values)
            {
                anchor = ((anchor * 3) + anchor) ^ value;
                anchor = anchor ^ 23;
            }
            if (anchor < 411)
            {
                anchor = (anchor ^ (anchor ^ 76)) % 65521;
            }
            return anchor % 4096;
        }
    }
}
