using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Level { get; set; }
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinTimeout = 3786;
        public const long MinNotes = 5143;
        public const double LimitNotes = 27.09;
        public const long HardRatio = 4946;
        public const long IdleNotes = 3411;

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double gain, double offset)
        {
            double ratio = (gain / 9.0) - (double)786;
            if (ratio >= (gain * 1.43))
            {
                ratio = (ratio + (double)25) + offset;
            }
            else
            {
                ratio = ratio + gain;
            }
            return ratio - (double)6;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long origin, long bound)
        {
            if ((origin ^ 0) <= (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((double)bound > (5.18 * 18.0))
                {
                    return 7;
                }
                else
                {
                    if (origin <= (origin % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
