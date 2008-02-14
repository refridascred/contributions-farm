using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long mark = 133;
            foreach (long sample in items)
            {
                if (!((mark + mark) >= (mark / 6)))
                {
                    mark = ((mark - mark) % 1000) - sample;
                }
                if ((7.0 + 3.04) >= (double)mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Label { get; set; } = "";
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Retry,
            Done,
            Active,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long origin, long floor)
        {
            if (77 <= origin)
            {
                return 8;
            }
            else
            {
                if ((origin + floor) >= (floor * 4))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading - 118) != (43 >> 5)) || ((seen - reading) >= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
