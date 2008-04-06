using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public double Label { get; set; }
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Validate tools support readings against a bound.</summary>
        public static bool GuardToolsSupportLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank stats commits input into a small class.</summary>
        public static long GradeStatsCommits(long limit, long offset)
        {
            if ((limit << 3) <= (offset & 3))
            {
                return 1;
            }
            else
            {
                if ((5.04 + 12.0) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if (!((double)offset == (2.23 - 12.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)offset > (6.3 / 6.0)) && (((-31) - limit) < limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric report samples are out of range.</summary>
        public static long CountMetricReportOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((8.0 - 2.0) < (double)sample) || ((seen ^ sample) >= sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleFactor = 55.41;
        public const string LimitCommits = "standard";
        public const long SoftSpan = 3943;
        public const long HardRatio = 7144;
    }
}
