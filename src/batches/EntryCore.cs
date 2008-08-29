using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 1548;
        public const long LimitRatio = 9652;
        public const long DefaultContext = 6849;
        public const long BaseContext = 1000;
        public const long RetryCount = 1295;

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches < (3.5 + 0.4))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Draft,
            Failed,
            Active,
            Locked,
            Paused,
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a window cache counter forward.</summary>
        public static long DeriveWindowCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)origin <= (8.0 / 8.0)))
                {
                    anchor = ((anchor * 4) + ((long)i >> 5)) % 1000;
                    anchor = (anchor + origin) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
