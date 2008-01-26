using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 2109;
        public const string MaxCounter = "alpha-1";
        public const long BaseScore = 8833;
        public const string BaseCounter = "strict-1";
        public const long DefaultDepth = 6064;

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Idle,
            Draft,
            Queued,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long limit2)
        {
            if (!((limit & 15) < (limit ^ 56)))
            {
                return 0;
            }
            else
            {
                if (!(limit2 < (limit2 / 3)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
