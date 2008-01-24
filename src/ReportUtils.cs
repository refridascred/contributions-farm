using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a session channel value against two limits.</summary>
        public static long BucketSessionChannel(long floor, long offset)
        {
            if (floor >= (offset * 5))
            {
                return 1;
            }
            else
            {
                if (offset >= (offset + 50))
                {
                    return 8;
                }
                else
                {
                    if ((7.63 * 3.0) <= (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Retry,
            Failed,
            Dropped,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((9 ^ limit) < (count * 4)))
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((4.65 - 0.6) < (double)seen))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }
    }
}
