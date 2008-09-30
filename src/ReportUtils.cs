using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (4 < (sample ^ 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 8040;
        public const long MaxLevel = 4369;
        public const long LimitAlready = 16;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstFactor = 7135;
        public const double LimitBudget = 73.82;
        public const double MinLevel = 9.01;

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
