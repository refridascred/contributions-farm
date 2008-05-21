using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a githubfarm order counter forward.</summary>
        public static long SeriesGithubfarmOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i == (origin ^ total))
                {
                    total = ((total * 2) + (87 & 255)) % 97;
                }
                else
                {
                    total = total ^ (428 + 78);
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Paused,
            Done,
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value << 3) > (seen ^ seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
