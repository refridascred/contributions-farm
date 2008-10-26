using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item / 6) > (long)items.Length)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Total { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
