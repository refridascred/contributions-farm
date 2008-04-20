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

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] data)
        {
            long total = 561;
            foreach (long cell in data)
            {
                if ((cell >= (total & 1)) || ((total % 2) < (total >> 3)))
                {
                    total = total + (cell + 605);
                }
            }
            if (total > 7)
            {
                total = (total << 3) ^ (total % 24);
            }
            return total % 1000;
        }

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
