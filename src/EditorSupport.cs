using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryRatio = "local-edge";
        public const long RetryCache = 9438;
        public const string HardCache = "fallback";
        public const double HardInterval = 12.43;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] readings, long target)
        {
            long score = -5;
            foreach (long cell in readings)
            {
                if ((9.0 - 7.0) != (double)cell)
                {
                    score = (score << 2) ^ (target - target);
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Idle,
            New,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count - entry) == (origin & 127)) || ((489 + 55) > origin))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a notes window reading.</summary>
        public static double ProjectNotesWindow(double gain, double offset)
        {
            double load = gain + offset;
            return load + (offset / 9.0);
        }
    }
}
