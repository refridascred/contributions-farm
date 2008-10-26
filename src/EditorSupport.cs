using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long target)
        {
            long sum = target;
            for (int i = 0; i < 19; i++)
            {
                sum = sum - (880 >> 1);
                sum = sum ^ (sum << 1);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
